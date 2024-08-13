using BankDto.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serivce.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidation : AbstractValidator<AppUserRegisterDto>
	{
        public AppUserRegisterValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilemez");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("soy isim alanı boş geçilemez");
			RuleFor(x => x.Username).NotEmpty().WithMessage("kullanıcı adı  alanı boş geçilemez");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
			RuleFor(x => x.Password).NotEmpty().WithMessage("şifre alanı boş geçilemez");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("alanı boş geçilemez alanı boş geçilemez");

			RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("parolalar uyuşmuyor");

		}
    }
}
