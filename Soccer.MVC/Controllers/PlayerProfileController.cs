using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Data;
using Soccer.MVC.Models;

namespace Soccer.MVC.Controllers
{
    public class PlayerProfileController : Controller
    {

        private readonly SoccerMVCContext _context;


        public PlayerProfileController(SoccerMVCContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.Player != null ?
                         View(await _context.Player.ToListAsync()) :
                         Problem("Entity set 'SoccerMVCContext.Player'  is null.");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .FirstOrDefaultAsync(m => m.ID == id);
            if (player == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}