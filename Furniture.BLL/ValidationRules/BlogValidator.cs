using FluentValidation;
using Furniture.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.BLL.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogAdi).NotEmpty().WithMessage("Blog adı boş geçilmez.");            
            RuleFor(x => x.BlogIcerigi).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yazınız.");
            RuleFor(x => x.BlogIcerigi).NotEmpty().WithMessage("Blog adı boş geçilmez.");
            RuleFor(x => x.BlogGorseli).NotEmpty().WithMessage("Blog Görseli boş geçilmez.");
            RuleFor(x => x.Urun.UrunAdi).NotEmpty().WithMessage("ürün Adı boş geçilmez.");
        }
    }
}
