﻿using CiRent.DAL.Abstract;
using CiRent.DAL.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CiRent.DAL.Concrete.EF.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DAL.Abstract.ICiRentContext _context;

        public GenericRepository(DAL.Abstract.ICiRentContext context)
        {
            _context = context;
        }

        public ICiRentContext Context
        {
            get { return _context; }
        }

        public IDbSet<TEntity> DbSet
        {
            get { return Context.Set<TEntity>(); }
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync();
            return entity;

        }
        public virtual async Task UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> DeleteAsync(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where<TEntity>(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {

            return id <= 0 ? null : await ((DbSet<TEntity>)Context.Set<TEntity>()).FindAsync(id);
        }

        public virtual async Task<int> GetCountAsync()
        {
            return await Context.Set<TEntity>().CountAsync();
        }

        public virtual Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().CountAsync(predicate);
        }

        public virtual async Task<List<TEntity>> FetchAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<List<TEntity>> FetchByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<TEntity>> PaggingFetchAsync(int startIndex, int count)
        {
            return await Context.Set<TEntity>().Skip(startIndex).Take(count).ToListAsync();
        }

        public virtual async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<List<TEntity>> PaggingFetchByAsync(Expression<Func<TEntity, bool>> predicate, int startIndex, int count)
        {
            return await Context.Set<TEntity>().Where(predicate).Skip(startIndex).Take(count).ToListAsync();
        }

        public virtual async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        
        
    }
}
