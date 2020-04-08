using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AK.PartyInvites.MVC.Models;
using AK.PartyInvites.BL;

namespace AK.PartyInvites.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public ViewResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Rando = hour < 12 ? "Morning" : "Afternoon";
        //    return View("TheView");
        //}

        //public ViewResult RsvpForm()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            return View();
        }

    }
}
