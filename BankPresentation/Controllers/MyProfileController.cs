using BankDto.Dtos.AppUserDtos;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.Controllers
{
	[Authorize]
	public class MyProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

        public MyProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

		[HttpGet]
        public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);

            AppUserEditDtos appUserEditDtos = new AppUserEditDtos();

			appUserEditDtos.Name = values.Name;
			appUserEditDtos.Surename = values.Surname;
			appUserEditDtos.Email = values.Email;
			appUserEditDtos.PhoneNumber = values.PhoneNumber;
			appUserEditDtos.City = values.City;
			appUserEditDtos.District = values.District;	
			appUserEditDtos.ImageUrl = values.ImageUrl;
			


            return View(appUserEditDtos);
		}


        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDtos appUserEditDtos)
        {
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			if (appUserEditDtos.Password == appUserEditDtos.ConfirmPassword)
			{
                user.PhoneNumber = appUserEditDtos.PhoneNumber;
                user.Surname = appUserEditDtos.Surename;
                user.District = appUserEditDtos.District;
                user.City = appUserEditDtos.City;
                user.Name = appUserEditDtos.Name;
                user.ImageUrl = "test";
                user.Email = appUserEditDtos.Email;
               user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,appUserEditDtos.Password);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded) 
                { 
                   return RedirectToAction("Index", "Login");
                
                }


            }

            return View();

        }
    }
}
