using Microsoft.AspNetCore.Mvc;

namespace HelloASP{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [HttpGet("")]
        public string Index()
        {
            return "Hello from Controller";
        }

        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hi again";
        }
        
        [HttpGet("users/{username}")]
        public string HelloUser(string username){
            return $"Hello {username}";
        }
        
    }
}