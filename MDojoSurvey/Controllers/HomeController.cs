using Microsoft.AspNetCore.Mvc;

namespace MDojoSurvey
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("survey")]
        public IActionResult DojoSurvey(LangSurvey mysurvey)
        {
            
            return Json(mysurvey);
        }
    }
}