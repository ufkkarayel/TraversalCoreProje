using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz!...");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama 50 karakterden az olamaz!...");
            RuleFor(x => x.Description).MaximumLength(5000).WithMessage("Lütfen açıklamayı kısaltınız.");
        }
    }
}
