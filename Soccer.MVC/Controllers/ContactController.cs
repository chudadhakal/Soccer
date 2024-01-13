using Microsoft.AspNetCore.Mvc;

namespace Soccer.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
