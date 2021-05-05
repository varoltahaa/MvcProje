using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz !");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Boş Olamaz !");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapmak zorudasınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girişi yapmak zorudasınız");
        }
    }
}
