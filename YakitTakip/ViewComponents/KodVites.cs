using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Kod;

namespace YakitTakip.ViewComponents
{
    public class KodVites : ViewComponent
    {
        private readonly IKodReadRepository _kodReadRepository;
        public KodVites(IKodReadRepository kodReadRepository)
        {
            _kodReadRepository = kodReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_kodReadRepository.GetWhere(p => p.UstKodId == 13));
        }
    }
}
