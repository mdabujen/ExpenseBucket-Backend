﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseBucket.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken);

        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        Task<T> GetByIdAsync(object id, CancellationToken cancellationToken);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entitiy);
    }
}
