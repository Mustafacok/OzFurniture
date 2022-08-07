using FluentValidation;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.ValidationRules
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(x=>x.KategoriAdi).NotEmpty().WithMessage("Kategori adı boş geçilmez.");
            RuleFor(x=>x.Gorsel).NotEmpty().WithMessage("Görsel boş geçilmez.");
            RuleFor(x=>x.KategoriAdi).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yazınız.");
            RuleFor(x=>x.KategoriAdi).MaximumLength(20).WithMessage("Lütfen 20 karakterdan fazla değer girişi yapmayınız.");
        }
    }
}
