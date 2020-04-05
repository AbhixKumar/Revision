using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Database;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storage.Repositories
{
   public class PizzaRepository
   {
        private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
        public List<Pizza> GetPizzas()
        {
            //var pizzas = _db.Pizza.ToList();
            //return pizzas;
           return _db.Pizza.Include(p => p.crust.Name).Include(p => p.size.Name).Include(p =>p.PizzaTopping).Include(p =>p.Price).ToList();
        }

        public Pizza GetAPizza(long id)
        {
            return _db.Pizza.FirstOrDefault(p => p.PizzaId == id);
        }

        public bool Post(Pizza pizza)
        {
            _db.Pizza.Add(pizza);           
            return _db.SaveChanges() == 1;
        }

        public bool Post(Crust crust, Size size, List<Topping> toppings)
        {
            var p = new Pizza();

            crust.Pizzas = new List<Pizza> { p };
            size.Pizzas = new List<Pizza> { p };

            return Post(p);
        }

        public List<Pizza> Get()
        {
            return GetPizzas();
        }

    }
}
