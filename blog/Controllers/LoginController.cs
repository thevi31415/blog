using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
