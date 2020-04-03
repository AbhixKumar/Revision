using PizzaBox.Domain.Models;
using PizzaBox.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.Storage.Repositories
{
    public class SizeRepository
    {
        private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();

        public List<Size> GetAllSizes()
        {
            return _db.Size.ToList();
        }
    }
}
