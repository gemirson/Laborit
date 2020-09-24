using Flunt.Validations;
using Laborit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Service.Commands
{
    public class BrandCommandEdit: Command
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public BrandCommandEdit(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Validate()
        {
            AddNotifications(new Contract()
               .Requires()
               .IsNullOrEmpty(Name, nameof(Name), "O Nome não pode ser vazio"));

            AddNotifications(new Contract()
              .Requires()
              .IsNotEmpty(Id, nameof(Id), "O Id não pode ser vazio"));

        }
    }
}
