using YakitTakip.IRepository.Yakit;
using YakitTakip.Models;

namespace YakitTakip.Repository.Yakit
{
    public class YakitWriteRepository : WriteRepository<TbYakit>, IYakitWriteRepository
    {
        public YakitWriteRepository(DbYakitTakipContext context) : base(context)
        {
        }
    }
}
