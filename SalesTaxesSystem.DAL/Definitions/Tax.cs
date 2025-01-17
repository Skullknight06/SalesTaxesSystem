﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxesSystem.DAL.Definitions
{
    public class Tax
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public ICollection<string> Classes { get; set; }
        public ICollection<string> Exceptions { get; set; }
    }
}
