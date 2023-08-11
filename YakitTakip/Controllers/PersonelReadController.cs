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
        public IActionResult Detay(IFormCollection personel)
        {
            
            return View(_personelReadRepository.GetWhere(p => p.Id == personel["id"]));
        }
    }
}
