using PizzaBox.Domain.Models;
using PizzaBox.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Storage.Repositories
{
    public class CrustRepository
    {
        private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

        public Crust GetACrust(long id)
        {
            return _db.Crust.FirstOrDefault(c => c.CrustId == id);
        }

        public void Post()
        {
            var add = new Crust();
            _db.Crust.Add(add);
            _db.SaveChanges();           
        }

        public bool Put(Crust crust)
        {
            Crust c = GetACrust(crust.CrustId);

            c = crust;
            
           return _db.SaveChanges() == 1;
           
        }
    }
}
