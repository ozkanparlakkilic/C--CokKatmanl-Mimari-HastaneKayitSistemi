using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.ValidationRules.FluentValidation
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {

        public AppointmentValidator()
        {
            RuleFor(m => m.TC_NO).NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(m => m.MEMBER_NAME).NotEmpty().WithMessage("isim boş olamaz");
            RuleFor(m => m.MEMBER_SURNAME).NotEmpty().WithMessage("soyisim boş olamaz");
            RuleFor(m => m.DOCTOR_NAME).NotEmpty().WithMessage("doktor adı boş olamaz");
            RuleFor(m => m.POLYCLINICS_NAME).NotEmpty().WithMessage("polinik adı boş olamaz");
            RuleFor(m => m.APPOINTMENT_DATE).NotEmpty().WithMessage("tarih boş olamaz");
            RuleFor(m => m.APPOINTMENT_HOUR).NotEmpty().WithMessage("saat boş olamaz");
        }

    }
}
