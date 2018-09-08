using Microsoft.AspNetCore.Mvc;

namespace WalkintheWoods
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return View();
        }

    }
}