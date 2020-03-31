using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class PizzaOrder
    {
        public Order Order { get; set; }
        public long OrderId { get; set; }
        public Pizza Pizza { get; set; }
        public long PizzaId { get; set; }

    }
}
