using FluentValidation;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.ValidationRules
{
    public class UrunValidator: AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(x => x.UrunAdi).NotEmpty().WithMessage("Urun adı boş geçilmez.");
            RuleFor(x => x.UrunAciklama).NotEmpty().WithMessage("Urun Açıklaması boş geçilmez.");
            RuleFor(x => x.UrunGorseli).NotEmpty().WithMessage("Urun Gorseli boş geçilmez.");
            RuleFor(x => x.UrunAdi).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yazınız.");
            RuleFor(x => x.UrunAdi).MaximumLength(20).WithMessage("Lütfen 20 karakterdan fazla değer girişi yapmayınız.");
        }
    }
}
