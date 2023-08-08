using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelApiController : ControllerBase
    {
        private readonly IPersonelReadRepository _personelReadRepository;
        public PersonelApiController(IPersonelReadRepository personelReadRepository)
        {
            _personelReadRepository = personelReadRepository;
        }
        [HttpGet]
        public IQueryable<TbPersonel> Get()
        {
            return _personelReadRepository.GetWhere(p => p.Ad == "Nihat");
        }

    }
}
