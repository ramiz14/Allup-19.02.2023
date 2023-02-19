using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P133Allup.DataAccessLayer;
using P133Allup.Models;
using P133Allup.Services;
using P133Allup.ViewModels.HomeViewModels;

namespace P133Allup.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            HomeVM vm = new HomeVM
            {
                Sliders = await _context.Sliders.Where(c => c.IsDeleted == false).ToListAsync(),

                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain).ToListAsync(),

                BestSeller = await _context.Products.Where(c=>c.IsDeleted == false && c.IsBestSeller).ToListAsync(),

                Featured = await _context.Products.Where(c => c.IsDeleted == false && c.IsFeatured).ToListAsync(),

                NewProduct = await _context.Products.Where(c => c.IsDeleted == false && c.IsNewArrival).ToListAsync()

            };
            
            return View(vm);
        }
    }
}
