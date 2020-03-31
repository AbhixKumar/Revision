using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Database;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
    public class PizzaController : Controller
    {
       
        public ActionResult Index()
        {
            //var crust = new Crust();
            //var size = new Size();
            //var toppings = new List<Topping>();
            //var viewModel = new PizzaViewModel()
            //{
            //    Crust = crust,
            //    Size = size,
            //    Toppings = toppings
            //};
            PizzaRepository _pr = new PizzaRepository();
            var pz = _pr.GetPizzas();
            return View(pz);
        }

  

    }
}