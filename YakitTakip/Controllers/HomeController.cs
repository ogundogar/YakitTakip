using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DbYakitTakipContext _context=new DbYakitTakipContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var personel = _context.TbPersonels.ToList();
            ViewBag.ornek = "Personel";
            return View(personel);
        }

    }
}