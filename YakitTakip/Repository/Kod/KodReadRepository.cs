using YakitTakip.IRepository.Kod;
using YakitTakip.Models;

namespace YakitTakip.Repository.Kod
{
    public class KodReadRepository : ReadRepository<TbKod>, IKodReadRepository
    {
        public KodReadRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
