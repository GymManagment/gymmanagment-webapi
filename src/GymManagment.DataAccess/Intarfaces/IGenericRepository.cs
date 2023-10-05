﻿using GymManagment.Domain.Entities;
using System.Linq.Expressions;

namespace GymManagment.DataAccess.Intarfaces;

public interface IGenericRepository<TEntity> 
    where TEntity : BaseEntity
{
    public IQueryable<TEntity> GetAll();
    public IQueryable<TEntity> Where(Expression<Func<TEntity,bool>> expression);
    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
    public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
}
