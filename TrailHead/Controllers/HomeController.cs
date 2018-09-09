using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrailHead.Models;

namespace TrailHead.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("About")]
        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("AddTrail")]
        public IActionResult Create()
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("");
            }
            else
            {
                return View("About");
            }
        }

        
    }
}
