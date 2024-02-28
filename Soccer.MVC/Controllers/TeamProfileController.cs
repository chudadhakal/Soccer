

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Data;
using Soccer.MVC.Models.ViewModels;
using Soccer.MVC.Models;

namespace Soccer.MVC.Controllers
{

    public class TeamProfileController : Controller
    {
        private readonly SoccerMVCContext _context;

        public TeamProfileController(SoccerMVCContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //var result = _context.Player_Team != null ?
            //      View(await _context.Player_Team.ToListAsync()) :
            //      Problem("Entity set 'SoccerMVCContext.Player_Team' is null.");
            var result = _context.Player_Team != null ?
                   await _context.Player_Team.ToListAsync() : null;
            return View(result);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Player_Team == null)
            {
                return NotFound();
            }

            var award = await _context.Player_Team
                .FirstOrDefaultAsync(m => m.Team_ID == id);
            if (award == null)
            {
                return NotFound();
            }
            return View();
        }

    }
}
