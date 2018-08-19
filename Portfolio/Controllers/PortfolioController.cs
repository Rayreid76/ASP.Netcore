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

        [HttpGet("projectslink")]
        public RedirectResult Redirecting()
        {
            return Redirect("Projects");
        }
        [HttpGet("Projects")]
        
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contactlink")]

        public RedirectResult contatRedirect()
        {
            return Redirect("Contact");
        }

        [HttpGet("Contact")]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpGet("homelink")]

        public RedirectResult homeRedirect()
        {
            return Redirect("/");
        }
    }
}