using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        List<TEntity> GetAll();
        TEntity Update(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
    }
}
