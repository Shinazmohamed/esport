using Microsoft.AspNetCore.Mvc;

namespace esport.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
