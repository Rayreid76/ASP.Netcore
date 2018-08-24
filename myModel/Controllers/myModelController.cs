using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace myModel
{
    public class myModelController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            User user = new User()
            {
                FirstName = "Devon",
                LastName = "Newsom"
            };
            return View("Index", user);
            //Both of these returns will render the same view (You only need one!)
        }
    }
}