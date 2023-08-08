using YakitTakip.IRepository.Arac;
using YakitTakip.Models;

namespace YakitTakip.Repository.Arac
{
    public class AracWriteRepository : WriteRepository<TbArac>, IAracWriteRepository
    {
        public AracWriteRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
