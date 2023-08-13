using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;
using YakitTakip.Repository.Personel;

namespace YakitTakip.Controllers.API
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class PersonelApiController : ControllerBase
    {
        private readonly IPersonelReadRepository _personelReadRepository;
        public PersonelApiController(IPersonelReadRepository personelReadRepository)
        {
            _personelReadRepository = personelReadRepository;
        }
        [HttpGet]
        public IQueryable<TbPersonel> Personel()
        {
            return _personelReadRepository.GetAll();
        } 
        [HttpGet("{id}")]
        public IQueryable<TbPersonel> Personel(int id)
        {
            return _personelReadRepository.GetWhere(p => p.Id == id);
        }
    }
}
