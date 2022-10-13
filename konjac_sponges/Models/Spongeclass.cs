using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace konjac_sponges.Models
{
    public class SpongeClass
    {
         public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public decimal SpongeSize { get; set; }

        public string Color { get; set; }

        public string Shape { get; set; }

        public string Review { get; set; }
    }
}
