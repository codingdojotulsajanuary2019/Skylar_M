using Microsoft.AspNetCore.Mvc;

namespace RazorFun
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult index()
        {
            return View("index");
        }
    }
}