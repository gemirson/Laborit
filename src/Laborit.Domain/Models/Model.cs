using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Domain.Models
{
    public class Model:Entity
    {

        public string Name { get; private set; }
        public Guid    BrandId { get; private set; }



        public Model(string name, Guid IdBrand)
        {
            Id = Guid.NewGuid();
            Name = name;
            BrandId = IdBrand;
           
        }

        public Model()
        {
        }
    }
}
