using Microsoft.AspNetCore.Mvc;

namespace Portfolio1
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("projects");
        }
        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            return View("contact");
        }
    }

}

