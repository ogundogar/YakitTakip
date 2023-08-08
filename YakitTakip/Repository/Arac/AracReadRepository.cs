using YakitTakip.IRepository.Arac;
using YakitTakip.Models;

namespace YakitTakip.Repository.Arac
{
    public class AracReadRepository : ReadRepository<TbArac>, IAracReadRepository
    {
        public AracReadRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
