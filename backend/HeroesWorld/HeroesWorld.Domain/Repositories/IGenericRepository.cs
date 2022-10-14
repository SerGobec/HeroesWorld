using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HeroesWorld.Domain.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetById(long id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T? FirstOrDefault(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task<int> SaveChanges();
    }
}
