using Microsoft.AspNetCore.Mvc;
using Soccer.MVC.Models;

namespace Soccer.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                // Process the contact form (e.g., send email, save to database, etc.)
                // Redirect to a thank you page or show a success message


                return RedirectToAction("ThankYou");
            }
            // If model state is not valid, redisplay the form with validation errors

            return View(model);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
