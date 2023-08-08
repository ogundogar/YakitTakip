using YakitTakip.IRepository.Gorev;
using YakitTakip.Models;

namespace YakitTakip.Repository.Gorev
{
    public class GorevWriteRepository : WriteRepository<TbGorev>, IGorevWriteRepository
    {
        public GorevWriteRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
