using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public int OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public List<PizzaOrder> PizzaOrder { get;set; }

        public Order()
        {

        }
    }
}
