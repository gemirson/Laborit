using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Service.Commands
{
    public class ModelCommand
    {

        public string Name { get; private set; }
        public Guid BrandId { get; private set; }

        public ModelCommand(string name, Guid brandId)
        {
            Name = name;
            BrandId = brandId;
        }
    }
}
