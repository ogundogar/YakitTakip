using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;

namespace YakitTakip.ViewComponents
{
    public class Personel:ViewComponent
    {
        private readonly IPersonelReadRepository _personelReadRepository;
        public Personel(IPersonelReadRepository personelReadRepository)
        {
            _personelReadRepository = personelReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_personelReadRepository.GetAll());
        }

    }
}
