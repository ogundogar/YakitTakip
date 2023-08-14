using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Kod;

namespace YakitTakip.ViewComponents
{
    public class KodYakit : ViewComponent
    {
        private readonly IKodReadRepository _kodReadRepository;
        public KodYakit(IKodReadRepository kodReadRepository)
        {
            _kodReadRepository = kodReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_kodReadRepository.GetWhere(p => p.UstKodId == 16));
        }
    }
}
