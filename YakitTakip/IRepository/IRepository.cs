using Microsoft.EntityFrameworkCore;
using YakitTakip.Models;

namespace YakitTakip.IRepository
{
    public interface IRepository<T> where T:BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
