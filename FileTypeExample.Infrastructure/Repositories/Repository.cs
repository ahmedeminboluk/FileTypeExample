using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly FileTypeExampleDbContext _context = null;
        private readonly DbSet<TEntity> _entity;

        public Repository(FileTypeExampleDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public List<TEntity> GetAll()
        {
            return _entity.ToList();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entity.FindAsync(id);
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
                return null;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
