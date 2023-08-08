using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using YakitTakip.IRepository;
using YakitTakip.Models;

namespace YakitTakip.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private DbYakitTakipContext _context;
        public WriteRepository(DbYakitTakipContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry= await Table.AddAsync(model);
            return entityEntry.State==EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }
        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry= Table.Remove(model);
            return entityEntry.State==EntityState.Deleted;
        }
        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
           T model =await Table.FirstOrDefaultAsync(p => p.Id == id);
            return Remove(model);
        }
        public bool Update(T model)
        {
           EntityEntry<T> entityEntry= Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();

    }
}
