using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Arac;
using YakitTakip.IRepository.Kod;
using YakitTakip.Models;
using YakitTakip.Repository.Arac;

namespace YakitTakip.Controllers
{
    public class KodWriteController : Controller
    {
        private readonly IKodWriteRepository _kodWriteRepository;
        public KodWriteController(IKodWriteRepository kodWriteRepository)
        {
            _kodWriteRepository = kodWriteRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle(IFormCollection kod)
        {
            _kodWriteRepository.AddAsync(new()
            {
                Ad = kod["Ad"],
                UstKodId = long.Parse(kod["UstKodId"]),
                SiraNo = short.Parse(kod["SiraNo"]),
                Aciklama = kod["Aciklama"],
                AktifMi = true,
                IlkKayitTarihi=DateTime.Now,
                SonKayitTarihi=DateTime.Now,
            });
            _kodWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Guncelleme(IFormCollection kod)
        {
            _kodWriteRepository.Update(new()
            {
                Id = int.Parse(kod["Id"]),
                Ad = kod["Ad"],
                UstKodId = long.Parse(kod["UstKodId"]),
                SiraNo = short.Parse(kod["SiraNo"]),
                Aciklama = kod["Aciklama"],
                AktifMi = true,
                IlkKayitTarihi = DateTime.Now,
                SonKayitTarihi = DateTime.Now,
            });
            _kodWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Sil(TbKod kod)
        {
            _kodWriteRepository.Remove(kod);
            _kodWriteRepository.SaveAsync();
            return View();
        }
    }
}
