using Microsoft.AspNetCore.Mvc;

namespace ViewModels
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // model string array
            string[] message = new string[]
            {
                "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus sed expedita quia nostrum, esse officia voluptas laboriosam impedit, dolorem dolorum id similique veritatis, totam ab provident earum rem? Ratione, eligendi."
            };
            return View(message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,78,95,4,1,58,4,6,3,7,56,52,48,86
            };
            return View("Numbers",numbers);
        }

        [HttpGet("user")]
        public IActionResult Users()
        {
            string[] person = new string[]
            {
                "Big Bird", "Grover", "Elmo", "Cookie Monster"
            };
            return View("Users", person);
        }
    }
}