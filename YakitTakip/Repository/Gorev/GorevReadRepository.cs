using YakitTakip.IRepository.Gorev;
using YakitTakip.Models;

namespace YakitTakip.Repository.Gorev
{
    public class GorevReadRepository : ReadRepository<TbGorev>, IGorevReadRepository
    {
        public GorevReadRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
