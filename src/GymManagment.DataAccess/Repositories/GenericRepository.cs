using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces;
using GymManagment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GymManagment.DataAccess.Repositories;

public class GenericRepository<TEntity> : Repository<TEntity>, IGenericRepository<TEntity>
    where TEntity : BaseEntity
{
    public GenericRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)    
        => await _dbSet.FirstOrDefaultAsync(expression);
    
    public async Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        => await _dbSet.LastOrDefaultAsync(expression);

    public IQueryable<TEntity> GetAll()
        => _dbSet;


    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        => _dbSet.Where(expression);
}
