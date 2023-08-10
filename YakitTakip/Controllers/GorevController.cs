using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using YakitTakip.IRepository.Gorev;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class GorevController : Controller
    {
        private readonly IGorevReadRepository _gorevReadRepository;
        public GorevController(IGorevReadRepository gorevReadRepository)
        {
            _gorevReadRepository = gorevReadRepository;
        }
        public IActionResult Index()
        {
            return View(_gorevReadRepository.GetAll());
        }
    }
}
