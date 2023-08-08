using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Repository.Personel
{
    public class PersonelReadRepository : ReadRepository<TbPersonel>, IPersonelReadRepository
    {
        public PersonelReadRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
