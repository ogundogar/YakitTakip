using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Controllers
{
    public class PersonelWriteController : Controller
    {
        private readonly IPersonelWriteRepository _personelWriteRepository;
        public PersonelWriteController(IPersonelWriteRepository personelWriteRepository)
        {
            _personelWriteRepository = personelWriteRepository;
        }
        public  IActionResult Index(IFormCollection personel)
        {
           _personelWriteRepository.AddAsync(new()
            { Ad = personel["ad"].ToString(), Soyad = personel["soyad"].ToString(), TelefonNo = personel["telefon"].ToString(), AktifMi = true, IlkKayitTarihi = DateTime.Now }
            );
           _personelWriteRepository.SaveAsync();
            return View();
        }
    }
}
