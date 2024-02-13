

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Data;

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
    }
}
