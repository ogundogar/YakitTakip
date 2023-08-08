using YakitTakip.IRepository.Yakit;
using YakitTakip.Models;

namespace YakitTakip.Repository.Yakit
{
    public class YakitReadRepository : ReadRepository<TbYakit>, IYakitReadRepository
    {
        public YakitReadRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
