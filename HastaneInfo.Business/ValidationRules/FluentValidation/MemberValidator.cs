using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.TC_NO).NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(m => m.MEMBER_NAME).NotEmpty().WithMessage("isim boş olamaz");
            RuleFor(m => m.MEMBER_SURNAME).NotEmpty().WithMessage("soyisim boş olamaz");
            RuleFor(m => m.EMAIL).NotEmpty().WithMessage("email boş olamaz")
                .EmailAddress();
            RuleFor(m => m.USERNAME).NotEmpty().WithMessage("kullanıcı boş olamaz");
            RuleFor(m => m.PASSWORD).NotEmpty().WithMessage("şifre boş olamaz");

        }
    }
}
