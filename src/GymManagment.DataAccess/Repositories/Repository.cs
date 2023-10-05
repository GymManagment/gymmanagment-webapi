using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces;
using GymManagment.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.DataAccess.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected DbSet<TEntity> _dbSet;

    public Repository(AppDbContext appDbContext)
    {
        this._dbSet= appDbContext.Set<TEntity>();
    }
    public void Add(TEntity entity) => _dbSet.Add(entity);

    public void Delete(TEntity entity) => _dbSet.Remove(entity);

    public void Update(long id, TEntity entity)
    {
        entity.Id = id;
        _dbSet.Update(entity);
    }
    public async Task<TEntity?> GetByIdAsync(long id) => await _dbSet.FindAsync(id);

    public async Task<long> CountAsync()
        => await _dbSet.CountAsync();
}
