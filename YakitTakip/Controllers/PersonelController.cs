using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelReadRepository _personelReadRepository;
        public PersonelController(IPersonelReadRepository personelReadRepository)
        {
            _personelReadRepository = personelReadRepository;
        }
        public IActionResult Index()
        {
            return View(_personelReadRepository.GetAll());
        }
    }
}
