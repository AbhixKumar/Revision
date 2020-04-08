using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AK.PartyInvites.MVC.Models;
using AK.PartyInvites.BL;
using AK.PartyInvites.Storage;

namespace AK.PartyInvites.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Rando = hour < 12 ? "Morning" : "Afternoon";
            return View("TheView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(Guest guest)
        {
            //TODO: store response from guest
            GuestRepository.AddResponse(guest);
            return View("Greetings", guest);
        }
        
        public ViewResult ListResponses()
        {
            return View(GuestRepository.Guests.Where(r => r.WillAttend == true));
        }
    }
}
