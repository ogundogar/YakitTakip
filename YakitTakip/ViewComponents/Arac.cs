using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Arac;
using YakitTakip.IRepository.Personel;

namespace YakitTakip.ViewComponents
{
    public class Arac : ViewComponent
    {
        private readonly IAracReadRepository _aracReadRepository;
        public Arac(IAracReadRepository aracReadRepository)
        {
            _aracReadRepository = aracReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_aracReadRepository.GetAll());
        }

    }
}
