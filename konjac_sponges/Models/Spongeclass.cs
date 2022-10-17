using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// File: Spongeclass.cs
// Author Name: Het Natvarbhai Patel
// Student i'd: 0805024

namespace konjac_sponges.Models
{
    public class SpongeClass
    {
        // Basic variables to retrive data..
         public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public decimal SpongeSize { get; set; }

        public string Color { get; set; }

        public string Shape { get; set; }

        public int Review { get; set; }
    }
}
