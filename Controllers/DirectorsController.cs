using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class DirectorsController : Controller

    {
        private readonly MvcMovieContext _context;

        public DirectorsController(MvcMovieContext context)
        {
            _context = context;
        }

   
        public async Task<IActionResult> Index()
        {
            return View(await _context.Directors.ToListAsync());
        }

 
    }
}