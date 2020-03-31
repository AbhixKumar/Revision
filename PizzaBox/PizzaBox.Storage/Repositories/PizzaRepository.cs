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
            var pizzas = _db.Pizza.ToList();
            return pizzas;
           // return _db.Pizza.Include(p => p.crust.Name).Include(p => p.size.Name).Include(p =>p.PizzaTopping).Include(p =>p.Price).ToList();
        }

        public Pizza GetAPizza(long id)
        {
            return _db.Pizza.FirstOrDefault(p => p.PizzaId == id);
        }
   }
}
