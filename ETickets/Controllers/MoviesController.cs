using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IActorsService _context;
        public MoviesController(IActorsService context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies= await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
