using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Service.Commands
{

    public class VehicleCommand
    {
        public string Name { get; private set; }
        public Guid BrandId { get; private set; }
        public Guid ModelsId { get; private set; }
        public decimal Value { get; private set; }
        public DateTime YearModel { get; set; }
        public int Fuel { get; set; }

        public VehicleCommand(string name, Guid brandId, Guid modelsId, decimal value, DateTime yearModel, int fuel)
        {
            Name = name;
            BrandId = brandId;
            ModelsId = modelsId;
            Value = value;
            YearModel = yearModel;
            Fuel = fuel;
        }
    }
}
