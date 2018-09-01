using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmit.Models;

namespace FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("user/Create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View("Result");
        }
    }
}
