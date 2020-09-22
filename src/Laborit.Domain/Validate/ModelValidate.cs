using FluentValidation;
using Laborit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Domain.Validate
{
    public class ModelValidate : AbstractValidator<Model>
    {
        public ModelValidate()
        {
            RuleFor(x => x.Name)
               .Matches(@"^[a-zA-Z\s]+$")
               .WithMessage("Campo nome aceita apenas letras");
          

        }
    

    }
}
