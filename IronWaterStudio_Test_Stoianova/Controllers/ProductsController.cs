using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IronWaterStudio_Test_Stoianova.Data;
using IronWaterStudio_Test_Stoianova.Models;

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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
