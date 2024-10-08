﻿using BankPresentation.Models;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        /// <summary>
        /// ///////////////////
        

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync
                                           (loginViewModel.Username, loginViewModel.Password,true,true);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(loginViewModel.Username);

                if (user.EmailConfirmed == true)
                
                {

                    return RedirectToAction("Index", "MyProfile");

                }
                // lütfen mail adresinizi onaylıyın 
                
            }

            return View();
        }

    }
}
