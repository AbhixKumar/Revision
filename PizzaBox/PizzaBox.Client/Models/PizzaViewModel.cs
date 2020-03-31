using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
    public class PizzaViewModel
    {
        private static readonly PizzaRepository _pr = new PizzaRepository();
        public Crust Crust { get; set; }
        public Size Size { get; set; }           
        public List<Crust> CrustList { get; set; }
        public List<Size> SizeList { get; set; }
        public List<Topping> Toppings { get; set; }
       
        public List<Pizza> Get()
        {
            return _pr.GetPizzas();
        }
        
    }
}
