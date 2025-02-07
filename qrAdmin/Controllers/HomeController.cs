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
            var bmenuler = _context.Urunler
                            .Where(u => u.Id >= 1 && u.Id <= 5)
                            .ToList();

            var hamburgerler = _context.Urunler
                            .Where(m => m.Id >= 6 && m.Id <= 10)
                            .ToList();

            var menuler = _context.Urunler
                           .Where(m => m.Id >= 6 && m.Id <= 10)
                           .ToList();

            var sandvicler = _context.Urunler
                           .Where(m => m.Id >= 6 && m.Id <= 10)
                           .ToList();

            var tostlar = _context.Urunler
                           .Where(m => m.Id >= 6 && m.Id <= 10)
                           .ToList();

            var salatalar = _context.Urunler
                           .Where(m => m.Id >= 6 && m.Id <= 10)
                           .ToList();







            var viewModel = new IndexViewModel
            {
                Hamburgerler = hamburgerler,
                BMenuler = bmenuler,
                Menuler = menuler,
                Sandvicler = sandvicler,
                Tostlar = tostlar
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
            var urunler = _context.Urunler.ToList();
            return View(urunler);
        }

        // **Fiyat Güncelleme Ýþlemi**
        [HttpPost]
        public IActionResult FiyatGuncelle(int id, int fiyat)
        {
            var urun = _context.Urunler.FirstOrDefault(u => u.Id == id);
            if (urun != null)
            {
                urun.Fiyat = fiyat;
                _context.SaveChanges();
            }
            return RedirectToAction("AdminPanel");
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
