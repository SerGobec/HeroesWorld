using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using HeroesWorld.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Repositories
{
    
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbSet<T> _table;
        private ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            this._table = context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _table.AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public T GetById(int id)
        {
            return _table.Find(id);
        }
        public void Remove(T entity)
        {
            _table.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _table.RemoveRange(entities);
        }
        public async Task<int> SaveChanges()
        {
            return await this._context.SaveChangesAsync();
        }
    }
}
