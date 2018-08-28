using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using survey.Models;

namespace survey.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(langSurvey results)
        {
            return RedirectToAction ("About", results);
        }
        [HttpGet("About")]

        public IActionResult About(langSurvey results)
        {
            
            return Json(results);
        }
    }
}
