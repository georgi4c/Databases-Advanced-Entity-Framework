﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Part
    {
        public Part()
        {
            this.Cars = new List<Car>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual Supplier Supplier { get; set; }
    }

}
