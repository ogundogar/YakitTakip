using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class PersonelReadController : Controller
    {
        private readonly IPersonelReadRepository _personelReadRepository;
        public PersonelReadController(IPersonelReadRepository personelReadRepository)
        {
            _personelReadRepository = personelReadRepository;
        }
        public IActionResult Index()
        {
            return View(_personelReadRepository.GetAll());
        }
        public IActionResult Detay(int id)
        {
            return View(_personelReadRepository.GetWhere(p => p.Id == id));
        }
        public IActionResult Guncelleme(int id)
        {
            return View(_personelReadRepository.GetWhere(p => p.Id == id));
        }
    }
}
