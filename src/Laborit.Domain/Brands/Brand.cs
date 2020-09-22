﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laborit.Domain.Brands
{
    public class Brand:Entity
    {
        public string Name { get; private set; }

        public Brand(int Id, string name)
        {
            this.Id = Id;
            this.Name = name;
            
        }
    }
}
