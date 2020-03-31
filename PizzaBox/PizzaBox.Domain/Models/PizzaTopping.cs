using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class PizzaTopping
    {
        public Pizza Pizza { get; set; }
        public long pizzaId { get; set; }
        public Topping Topping { get; set; }
        public long toppingId { get; set; }
    }
}
