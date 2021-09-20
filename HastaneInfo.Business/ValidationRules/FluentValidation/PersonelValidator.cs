using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HastaneInfo.DataAccess.Concrete.EntityFramework;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.ValidationRules.FluentValidation
{
    public class PersonelValidator : AbstractValidator<Personel>
    {

        private readonly HastaneDbContext _hastaneDbContext;
        public PersonelValidator(HastaneDbContext hastaneDbContext)
        {
            _hastaneDbContext = hastaneDbContext;
            RuleFor(p => p.TC_NO).NotEmpty().WithMessage("tc no boş olamaz");
            RuleFor(p => p.NAME).NotEmpty().WithMessage("isim boş olamaz");
            RuleFor(p => p.SURNAME).NotEmpty().WithMessage("soyisim boş olamaz");
            RuleFor(p => p.EMAIL).NotEmpty().WithMessage("email boş olamaz")
                .EmailAddress().WithMessage("email alanı doğru formatta olmalıdır");
        }

        //private bool UniqueEmail(string email)
        //{
        //    return _hastaneDbContext.Personels.FirstOrDefault(p => p.EMAIL == email) == null;
        //}
    }
}
