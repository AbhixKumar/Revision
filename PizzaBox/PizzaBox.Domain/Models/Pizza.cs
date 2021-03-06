﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {
        public long PizzaId { get; set; }
        public Size size { get; set; }
        public Crust crust { get; set; }
        public List<PizzaTopping> PizzaTopping { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
        public decimal Price { get; set; }
        
        public Pizza(Crust _crust,Size _size, List<PizzaTopping> _pizzatopping)
        {
            crust = _crust;
            size = _size;
            PizzaTopping = _pizzatopping;
        }

        public Pizza()
        {

        }

    }
}
