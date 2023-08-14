using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Arac;
using YakitTakip.IRepository.Gorev;
using YakitTakip.Models;
using YakitTakip.Repository.Gorev;

namespace YakitTakip.Controllers
{
    public class AracWriteController : Controller
    {
        private readonly IAracWriteRepository _aracWriteRepository;
        public AracWriteController(IAracWriteRepository aracWriteRepository)
        {
            _aracWriteRepository= aracWriteRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle(IFormCollection arac)
        {
            _aracWriteRepository.AddAsync(new()
            {

                Plaka = arac["Plaka"],
                MuayeneDurumu = true,
                MuayeneGecerlilikTarihi = DateTime.Parse(arac["MuayeneGecerlilikTarihi"]),
                Km = int.Parse(arac["Km"]),
                MarkaKodId = int.Parse(arac["MarkaKodId"]),
                ModelKodId = int.Parse(arac["ModelKodId"]),
                VitesKodId = int.Parse(arac["VitesKodId"]),
                YakitTipiKodId = int.Parse(arac["YakitTipiKodId"]),
                MotorGucu = int.Parse(arac["MotorGucu"]),
                MotorHacmi = int.Parse(arac["MotorHacmi"]),
                AktifMi = true,
                IlkKayitTarihi = DateTime.Now,
                SonKayitTarihi = DateTime.Now,
            });
            _aracWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Guncelleme(IFormCollection arac)
        {
            _aracWriteRepository.Update(new()
            {
                Id= int.Parse(arac["Id"]),
                Plaka = arac["Plaka"].ToString(),
                MuayeneDurumu = true,
                MuayeneGecerlilikTarihi = DateTime.Parse(arac["MuayeneGecerlilikTarihi"]),
                Km = int.Parse(arac["Km"]),
                MarkaKodId = int.Parse(arac["MarkaKodId"]),
                ModelKodId = int.Parse(arac["ModelKodId"]),
                VitesKodId = int.Parse(arac["VitesKodId"]),
                YakitTipiKodId = int.Parse(arac["YakitTipiKodId"]),
                MotorGucu = int.Parse(arac["MotorGucu"]),
                MotorHacmi = int.Parse(arac["MotorHacmi"]),
                AktifMi = true,
                IlkKayitTarihi = DateTime.Now,
                SonKayitTarihi = DateTime.Now,
            });
            _aracWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Sil(TbArac arac)
        {
            _aracWriteRepository.Remove(arac);
            _aracWriteRepository.SaveAsync();
            return View();
        }
    }
}
