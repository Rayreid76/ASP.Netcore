using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        

        
        [HttpGet("")]
        
        public ViewResult Index()
        {
            return View();
        }
    }
}