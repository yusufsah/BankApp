using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Concrete;
using Serivce.Abrstract;

namespace BankPresentation.Controllers
{
    public class AccountListForCopyController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountService _customerAccountService;

        public AccountListForCopyController(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager = userManager;
            _customerAccountService = customerAccountService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);


            
           

             var values =_customerAccountService.TGetCustomerAccountinformation(user.Id);

            return View(values);
        }
    }
}
