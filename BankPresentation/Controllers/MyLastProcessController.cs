using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Concrete;
using Serivce.Abrstract;

namespace BankPresentation.Controllers
{
    public class MyLastProcessController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public MyLastProcessController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);


            var contxt = new Context();
            int id = contxt.customerAccounts.Where(x=>x.AppUserID == user.Id && x.Currency=="TL")
                                          .Select(y=>y.CustomerAccountID).FirstOrDefault();

            var values = _customerAccountProcessService.TMyLastProces(id);



            return View(values);
        }
    }
}
