using YakitTakip.IRepository.Personel;
using YakitTakip.Models;

namespace YakitTakip.Repository.Personel
{
    public class PersonelWriteRepository : WriteRepository<TbPersonel>, IPersonelWriteRepository
    {
        public PersonelWriteRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
