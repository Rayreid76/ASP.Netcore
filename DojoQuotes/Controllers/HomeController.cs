using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoQuotes.Models;
using System.Collections.Generic;

namespace DojoQuotes.Controllers

{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //return View();
            //OR
            return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
        [HttpPost("Create")]
        public IActionResult create(Quote passage)
        {
            if(ModelState.IsValid){
                string insert = $@"INSERT INTO quote(name, quote, created_at) VALUES('{passage.Name}', '{passage.quote}', NOW())";
                DbConnector.Execute(insert);
                return RedirectToAction("DashBoard");
            }
            else{
                return View("Index");
            }
        }
        [HttpGet("DashBoard")]
        public IActionResult Dashboard()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quote");
            ViewBag.posted = AllQuotes;
            return View("QuoteList");
        }
        

    }
}