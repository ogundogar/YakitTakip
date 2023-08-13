using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Gorev;
using YakitTakip.Models;
using YakitTakip.Repository.Gorev;

namespace YakitTakip.Controllers
{
    public class GorevWriteController : Controller
    {
        private readonly IGorevWriteRepository _gorevWriteRepository;
        public GorevWriteController(IGorevWriteRepository gorevWriteRepository)
        {
            _gorevWriteRepository = gorevWriteRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle(IFormCollection gorev)
        {
            _gorevWriteRepository.AddAsync(new()
            {
                
                PersonelId = int.Parse(gorev["personel"]),
                AracId = int.Parse(gorev["arac"]),
                Aciklama = gorev["acıklama"],
                GorevBaslangicTarihi = DateTime.Parse(gorev["baslangicTarihi"]),
                GorevSonuTarihi = DateTime.Parse(gorev["sonuTarihi"]),
                BaslangicKm = int.Parse(gorev["baslangicKm"]),
                BitisKm = int.Parse(gorev["bitisKm"]),
                GorevTipiKodId=3,
                IlkKayitTarihi=DateTime.Now,
                SonKayitTarihi=DateTime.Now,
                AktifMi=true
            });
            _gorevWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Guncelleme(IFormCollection gorev)
        {
            _gorevWriteRepository.Update(new()
            {
                Id = int.Parse(gorev["id"]),
                PersonelId = int.Parse(gorev["personel"]),
                AracId = int.Parse(gorev["arac"]),
                Aciklama = gorev["acıklama"],
                GorevBaslangicTarihi = DateTime.Parse(gorev["baslangicTarihi"]),
                GorevSonuTarihi = DateTime.Parse(gorev["sonuTarihi"]),
                BaslangicKm = int.Parse(gorev["baslangicKm"]),
                BitisKm = int.Parse(gorev["bitisKm"]),
                GorevTipiKodId = 3,
                IlkKayitTarihi = DateTime.Now,
                SonKayitTarihi = DateTime.Now,
                AktifMi = true
            });
            _gorevWriteRepository.SaveAsync();
            return View();
        }
        public IActionResult Sil(TbGorev gorev)
        {
            _gorevWriteRepository.Remove(gorev);
            _gorevWriteRepository.SaveAsync();
            return View();
        }
    }
}
