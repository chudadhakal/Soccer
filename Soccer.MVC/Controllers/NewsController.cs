using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Data;
using Soccer.MVC.Models;

namespace Soccer.MVC.Controllers
{
    public class NewsController : Controller
    {
        private readonly SoccerMVCContext _context;
        public NewsController(SoccerMVCContext context 
            )
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var result = _context.News != null ? await _context.News.ToListAsync() : null;// Problem("Entity set 'SoccerMVCContext.News'  is null.");
       return View(result) ;
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.ID == id);
            if (news == null)
            {
                return NotFound();
            }
            return View();
        }
    }


}
