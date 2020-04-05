using PizzaBox.Domain.Models;
using PizzaBox.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Storage.Repositories
{
    public class StoreRepository
    {
        private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

        public List<Store> GetStores()
        {
            return _db.Store.ToList();
        }

        public Store GetStoreName(string name)
        {
            return _db.Store.SingleOrDefault(s => s.StoreLocation == name);
        }

       
    }
}
