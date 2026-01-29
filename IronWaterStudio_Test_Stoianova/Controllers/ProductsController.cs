using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IronWaterStudio_Test_Stoianova.Data;
using IronWaterStudio_Test_Stoianova.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace IronWaterStudio_Test_Stoianova.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToArrayAsync();
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if(ModelState.IsValid)
            {

            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            return RedirectToAction("Edit", "Products");
        }
    }
}
