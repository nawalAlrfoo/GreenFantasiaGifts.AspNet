using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenFantasiaGifts011.Data;
using GreenFantasiaGifts011.Models;

namespace GreenFantasiaGifts011.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            // ??? ?????? ?? ????? ???????? ???????? ??????
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}