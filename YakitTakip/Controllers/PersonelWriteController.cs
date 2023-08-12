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
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult Ekle(IFormCollection personel)
        {
           _personelWriteRepository.AddAsync(new()
            { Ad = personel["ad"].ToString(), Soyad = personel["soyad"].ToString(), TelefonNo = personel["telefon"].ToString(), AktifMi = true, IlkKayitTarihi = DateTime.Now }
            );
           _personelWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Guncelleme(TbPersonel personel)
        {
            _personelWriteRepository.Update(personel);
            _personelWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Sil(TbPersonel personel)
        {
            _personelWriteRepository. Remove(personel);
            _personelWriteRepository.SaveAsync();
            return View();
        }
    }
}
