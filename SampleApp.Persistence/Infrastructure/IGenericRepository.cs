using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleApp.Data;

namespace SampleApp.Persistence.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : IBaseEntity
    {
        Task CreateAsync(TEntity entity);

        Task CreateBulkAsync(List<TEntity> entities);

        Task DeleteAsync(TEntity entity);

        Task DeleteByIdAsync(string id);

        Task DeleteBulkAsync(List<TEntity> entities);

        Task Update(TEntity entity);

        Task<TEntity> GetById(string id);

        Task<IEnumerable<TEntity>> Filter(Func<TEntity, bool> predicate);

        Task SaveChangesAsync();
    }
}