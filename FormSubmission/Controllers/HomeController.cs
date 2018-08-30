using FormSubmission.Models;
using Microsoft.AspNetCore.Mvc;


namespace FormSubmission
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult userInfo(Users results)
        {
            
            return Json(results);

        }
        
    }
}
