using Flunt.Validations;
using Laborit.Domain.Core.Commands;
using System;

namespace Laborit.Service.Commands
{
    public class BrandCommandDelete: Command
    {
        public Guid Id { get; private set; }

        public BrandCommandDelete(Guid id)
        {
            Id = id;
        }

        public void Validate()
        {
            AddNotifications(new Contract()
              .Requires()
              .IsNotEmpty(Id, nameof(Id), "O Id não pode ser vazio"));

        }
    }
}
