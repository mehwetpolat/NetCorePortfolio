using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator: AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.PortfolioName).NotEmpty().WithMessage("Proje Adı Boş Bırakılamaz");
            RuleFor(x => x.PortfolioImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Bırakılamaz");
            RuleFor(x => x.PortfolioImageUrl2).NotEmpty().WithMessage("Görsel Alanı Boş Bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alanı Boş Bırakılamaz");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş Bırakılamaz");
            RuleFor(x => x.PortfolioName).MinimumLength(5).WithMessage("Proje Adı 5 Karakterden Uzun Olmalıdır");
            RuleFor(x => x.PortfolioName).MaximumLength(100).WithMessage("Proje Adı 100 Karakterden Kısa Olmalıdır");
        }
    }
}
