using GymManagment.Domain.Entities;

namespace GymManagment.DataAccess.Intarfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public void Add(TEntity entity);
    public void Update(long id, TEntity entity);
    public void Delete(TEntity entity);
    public Task<TEntity?> GetByIdAsync(long id);
    public Task<long> CountAsync();

}
