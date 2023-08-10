using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class HomeController : Controller
    {
        DbYakitTakipContext _context=new DbYakitTakipContext();
        public IActionResult Index()
        {
            var personel = _context.TbPersonels.ToList();
            ViewBag.ornek = "Personel";
            return View(personel);
        }

    }
}