using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Domain.Models
{
    public class Model:Entity
    {

        public string Name { get; private set; }
        public int    BrandId { get; private set; }



        public Model(int IdModel, string name, int IdBrand)
        {
            Id = IdModel;
            Name = name;
            BrandId = IdBrand;
           
        }

        public Model()
        {
        }
    }
}
