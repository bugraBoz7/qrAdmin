using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qrAdmin.Data;
using qrAdmin.Models;

namespace qrAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var urunler = _context.Urunler
                            .Where(u => u.Id >= 1 && u.Id <= 18)
                            .ToList();

            var menuler = _context.Urunler
                            .Where(m => m.Id >= 19)
                            .ToList();

            var viewModel = new IndexViewModel
            {l
                Urunler = urunler,
                Menuler = menuler
            };

            return View(viewModel);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return RedirectToAction("AdminPanel", "Home"); // Admin paneline yönlendir
            }

            ViewBag.ErrorMessage = "Hatalý kullanýcý adý veya þifre!";
            return View();
        }

        public IActionResult AdminPanel()
        {
            ViewBag.Urunler = _context.Urunler.ToList();
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
