using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation.FluentValidation
{
    public class TravelValidator : AbstractValidator<Travel>
    {
        public TravelValidator()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Bos ola bilmez").MinimumLength(3).WithMessage("Ad uzunlugu 3den kicik ola bilmez");
        }
    }
}
