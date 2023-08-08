using YakitTakip.IRepository.Kod;
using YakitTakip.Models;

namespace YakitTakip.Repository.Kod
{
    public class KodWriteRepository : WriteRepository<TbKod>, IKodWriteRepository
    {
        public KodWriteRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
