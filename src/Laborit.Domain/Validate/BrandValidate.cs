using FluentValidation;
using Laborit.Domain.Brands;

namespace Laborit.Domain.Validate
{
    public class BrandValidate : AbstractValidator<Brand>
    {
        public BrandValidate()
        {
            RuleFor(x => x.Name)
                .Matches(@"^[a-zA-Z\s]+$")
                .WithMessage("Campo nome aceita apenas letras");

            RuleFor(x => x.Name)
                .MinimumLength(8)
                .WithMessage("Campo nome aceita no minimo 8 caracteres");

            RuleFor(x => x.Name)
                .MaximumLength(40)
                .WithMessage("Campo nome aceita no maximo 40 caracteres");


        }
    
    }
}
