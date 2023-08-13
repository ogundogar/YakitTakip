using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using YakitTakip.IRepository.Gorev;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;
using YakitTakip.Repository.Personel;

namespace YakitTakip.Controllers
{
    public class GorevReadController : Controller
    {
        private readonly IGorevReadRepository _gorevReadRepository;
        public GorevReadController(IGorevReadRepository gorevReadRepository)
        {
            _gorevReadRepository = gorevReadRepository;
        }
        public IActionResult Index()
        {
            return View(_gorevReadRepository.GetAll().Include(p => p.Personel).Include(a=>a.Arac)); ;
        }
        public IActionResult Ekle()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            return View(_gorevReadRepository.GetWhere(p => p.Id == id).Include(p => p.Personel).Include(a => a.Arac));
        }
        public IActionResult Guncelleme(int id)
        {
            return View(_gorevReadRepository.GetWhere(p => p.Id == id).Include(p => p.Personel).Include(a => a.Arac));
        }
    }
}
