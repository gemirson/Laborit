using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Domain.Brands
{
    public class Brand:Entity
    {
        public string Name { get; private set; }

        public Brand( string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            
        }

        public void UpdateBrand(string name) 
        {
            Name = name;
        }
    }
}
