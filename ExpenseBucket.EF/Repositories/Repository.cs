﻿using ExpenseBucket.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseBucket.EF.Repositories
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private DbSet<T> _set;

        protected DbSet<T> Set 
            => _set ?? (_set = _context.Set<T>());

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            Set.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Set.AddRange(entities);
        }

        public List<T> GetAll()
        {
            return Set.ToList();
        }

        public Task<List<T>> GetAllAsync()
        {
            return Set.ToListAsync();
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return Set.ToListAsync(cancellationToken);
        }

        public T GetById(object id)
        {
            return Set.Find(id);
        }

        public Task<T> GetByIdAsync(object id)
        {
            return Set.FindAsync(id);
        }

        public Task<T> GetByIdAsync(object id, CancellationToken cancellationToken)
        {
            return Set.FindAsync(id, cancellationToken);
        }                

        public void Remove(T entity)
        {
            Set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Set.RemoveRange(entities);
        }

        public void Update(T entitiy)
        {
            var entry = _context.Entry(entitiy);
            if (entry.State == EntityState.Detached)
            {
                Set.Attach(entitiy);
                entry = _context.Entry(entitiy);
            }
            entry.State = EntityState.Modified;
        }
    }
}
