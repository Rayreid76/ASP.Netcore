using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private const string V = "{name}";

        [Route("")]
        [HttpGet]
        
        public string Index()
        {
            return "Hello, this is the index page.";
        }
    }
}