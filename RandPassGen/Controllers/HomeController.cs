using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RandPassGen.Controllers
{
    public class HomeController : Controller
    {
        private int? _countinsessin
        {
            get { return HttpContext.Session.GetInt32("Visit");}
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            
            Random rand = new Random();
            char[] password = {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','!','#','$','&','(',')','1','2','3','4','5','6','7','8','9','0'
            };
            List<int> t = new List<int>();
            List<char> sample = new List<char>();
            for(int idx = 0; idx < 14; idx++)
            {
                t.Add(rand.Next(0, password.Length));
                sample.Add(password[t[idx]]);
            }
            
            ViewBag.PassCode = sample;

            if(_countinsessin == null)
                HttpContext.Session.SetInt32("Visit", 0);


            ViewBag.Visits = _countinsessin;
            //ViewBag.PassCode = Guid.NewGuid().ToString("N");
            return View("Index");
        }
        [HttpGet("submit")]
        public IActionResult Submit()
        {
            int? currentCount = _countinsessin;
            if(currentCount == null)
                return RedirectToAction("Index");
            currentCount++;
            HttpContext.Session.SetInt32("Visit", (int)currentCount);
            return RedirectToAction("Index");
        }
    }
}