using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
