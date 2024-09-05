using BankDto.Dtos.CustomerAccountProcessDtos;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Concrete;
using Serivce;
using Serivce.Abrstract;

namespace BankPresentation.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }


        //

        [HttpGet]
        public IActionResult Index(string Currency)   // bunu linkte tl ve para birinin neolduğunu algılamsı için yaptık 
        {
            ViewBag.Currency = Currency;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var receiverAccountNumberID = context.customerAccounts.Where
              (x => x.CustomerAccountNubmer == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber)
                                                              .Select(y => y.CustomerAccountID).FirstOrDefault();

            //sendMoneyForCustomerAccountProcessDto.SenderID = user.Id;
            //sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //sendMoneyForCustomerAccountProcessDto.ProcessType = "Havale";
            //sendMoneyForCustomerAccountProcessDto.ReveiverID = receiverAccountNumberID;

            var SenderAccountNumberID = context.customerAccounts.
                                                Where(x => x.AppUserID == user.Id).Where(y => y.Currency == "TL")
                                                .Select(z => z.CustomerAccountID).FirstOrDefault();

            var valuse = new CustomerAccountProcess();
            valuse.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            valuse.SenderID = SenderAccountNumberID;
            valuse.ProcessType = "Havale";
            valuse.ReveiverID = receiverAccountNumberID;
            valuse.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            valuse.Description = sendMoneyForCustomerAccountProcessDto.Description;


            _customerAccountProcessService.TInsert(valuse);




            return RedirectToAction("Index", "deneme");
        }
    }
}
