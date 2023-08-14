using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YakitTakip.IRepository.Arac;
using YakitTakip.Repository.Arac;

namespace YakitTakip.Controllers 
{
    public class AracReadController : Controller
    {
        private readonly IAracReadRepository _aracReadRepository;
        public AracReadController(IAracReadRepository aracReadRepository)
        {
            _aracReadRepository = aracReadRepository;
        }
        public IActionResult Index()
        {
            return View(_aracReadRepository.GetAll().
                Include(marka=>marka.MarkaKod).
                Include(model => model.ModelKod).
                Include(vites => vites.VitesKod).
                Include(yakit => yakit.YakitTipiKod)); 
        }
        public IActionResult Ekle()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            return View(_aracReadRepository.GetWhere(p => p.Id == id).
                Include(marka => marka.MarkaKod).
                Include(model => model.ModelKod).
                Include(vites => vites.VitesKod).
                Include(yakit => yakit.YakitTipiKod));
        }
        public IActionResult Guncelleme(int id)
        {
            return View(_aracReadRepository.GetWhere(p => p.Id == id));
        }
    }
}
