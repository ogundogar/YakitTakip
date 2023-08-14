using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Kod;

namespace YakitTakip.ViewComponents
{
    public class KodModel : ViewComponent
    {
        private readonly IKodReadRepository _kodReadRepository;
        public KodModel(IKodReadRepository kodReadRepository)
        {
            _kodReadRepository = kodReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_kodReadRepository.GetWhere(p => p.UstKodId == 9));
        }
    }
}
