using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Arac;
using YakitTakip.IRepository.Kod;

namespace YakitTakip.Controllers
{
    public class KodReadController : Controller
    {
        private readonly IKodReadRepository _kodReadRepository;
        public KodReadController(IKodReadRepository kodReadRepository)
        {
            _kodReadRepository = kodReadRepository;
        }
        public IActionResult Index()
        {
            return View(_kodReadRepository.GetAll());
        }
        public IActionResult Ekle()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            return View(_kodReadRepository.GetWhere(p => p.Id == id));
        }
        public IActionResult Guncelleme(int id)
        {
            return View(_kodReadRepository.GetWhere(p => p.Id == id));
        }
    }
}
