using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AK.MovieStore.MVC.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from Store.Index()";
        }
    }
}