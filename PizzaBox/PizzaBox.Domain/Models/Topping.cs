using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class Topping
    {
        
        public long ToppingId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<PizzaTopping> PizzaTopping { get; set; }

        public Topping()
        {
           
        }
    }
}
