using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P133Allup.DataAccessLayer;
using P133Allup.Models;

namespace P133Allup.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Brand> brands= await _context.Brands.Include(b=>b.Products.Where(p=>p.IsDeleted==false)).Where(b=>b.IsDeleted==false).ToListAsync();
            return View(brands);
        }
    }
}
