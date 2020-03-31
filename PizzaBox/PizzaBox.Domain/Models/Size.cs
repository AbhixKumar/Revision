using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PizzaBox.Domain.Models
{
   public class Size
   {    
       
        public long SizeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Size()
        {
           
        }
   }
}
