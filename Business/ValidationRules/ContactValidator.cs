using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş olamaz");
            RuleFor(x => x.UserMail).EmailAddress().WithMessage("Hatalı Mail Adresi Girişi Yaptınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adı boş olamaz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu alanı en az 3 karakter olmalı");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu alanı en fazla 50 karakter olmalı");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalı");
        }
    }
}
