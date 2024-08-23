using BankDto.Dtos.AppUserDtos;
using Entity;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace BankPresentation.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		//
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
		{
			if (ModelState.IsValid) 
			{
				Random random = new Random();
				int code;
				code = random.Next(100000, 1000000);
				AppUser appUser = new AppUser()

				{
					UserName = appUserRegisterDto.Username,
					Name = appUserRegisterDto.Name,
					Surname = appUserRegisterDto.Surname,
					Email = appUserRegisterDto.Email,
					City = "aaa",
					District ="yenibosna",
					ImageUrl ="ccc",
					ConfirmCode = code


				};
				var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
				if (result.Succeeded)
				{ 
				   MimeMessage mimeMessage = new MimeMessage();  // mesaj için apket yükeleyim nesne örneği aldık
					MailboxAddress mailboxAddressFrom = new MailboxAddress("Yusuf Bank ","kahya.yusufsahin@gmail.com");
					MailboxAddress mailboxAddressTo = new MailboxAddress("User",appUser.Email);


					mimeMessage.From.Add(mailboxAddressFrom);
					mimeMessage.To.Add(mailboxAddressTo);




					var bodyBuilder = new BodyBuilder();


					bodyBuilder.TextBody= " Kayıt İşlemini Gerçekleştirmek İçin Onay Kodunuz "+ code;

				    mimeMessage.Body= bodyBuilder.ToMessageBody();


					mimeMessage.Subject = " Yusuf Bank Kayıt İşlemi ";




					SmtpClient smtpClient = new SmtpClient();
					smtpClient.Connect("smtp.gmail.com", 587, false);
					smtpClient.Authenticate("kahya.yusufsahin@gmail.com", "ggbm pubz hvtd ogpr");
					smtpClient.Send(mimeMessage);
					smtpClient.Disconnect(true);

					TempData["Mail"] = appUserRegisterDto.Email;
					return RedirectToAction("Index", "ConfirmMail");
				
				}
                else
                {
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
                }

            }
			return View();	
		}

	}
}
