using Microsoft.AspNetCore.Identity;

namespace BankPresentation.Models
{
	public class CustomerIdentityValidation : IdentityErrorDescriber
	{
		// 1.
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{

				Code = "PasswordTooShort",
				Description = $"parola en az {length} karakter olmalıdır "

			};
		}

		//2.
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresUpper",
				Description = "Lütfen en az 1 büyük karakter  giriniz  "


			};
		}
		//3.
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresLower",
				Description = " Lütfen en az 1 küçük harf giriniz  "


			};


		}
		//4.
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresDigit",
				Description = " Lüften en az 1 tane rakam giriniz  "


			};
		}
		//5.
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Lüften en az 1 tane sembol  giriniz "


			};

		}
	}
}
