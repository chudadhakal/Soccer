using Microsoft.AspNetCore.Mvc;

namespace Soccer.MVC.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
