using Flunt.Validations;
using Laborit.Domain.Core.Commands;
using System;

namespace Laborit.Service.Commands
{
    public class BrandCommandCreate: Command
    { 
        public string Name { get; private set; }

        public BrandCommandCreate(string name)
        {
            Name = name;
        }

        public void Validate()
        {
            AddNotifications(new Contract()
               .Requires()
               .IsNotEmpty(Guid.NewGuid(), nameof(Name), "O Nome não pode ser vazio"));

            
        }


       

    }
}
