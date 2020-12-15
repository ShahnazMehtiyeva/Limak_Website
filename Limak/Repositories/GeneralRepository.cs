﻿using Limak.Abstractions;
using Limak.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limak.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        private readonly ApplicationContext context;
        private readonly DbSet<T> db;
        public GeneralRepository(ApplicationContext context)
        {
            this.context = context;
            db = context.Set<T>();
        }
        public async Task<T> Create(T entity)
        {
            if (entity != null)
            {
                await db.AddAsync(entity);
                var result = await SaveChanges();
                if (result > 0)
                {
                    return entity;

                }
            }
            return null;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await db.FindAsync(id);
            if (entity != null)
            {
                db.Remove(entity);
                var result = await SaveChanges();
                if (result > 0)
                {
                    return true;

                }
            }
            return false;
        }

        public async Task<bool> Edit(T entity)
        {
            context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);
            context.Entry(entity).State = EntityState.Modified;
            var result = await SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<T>> GetAll()
        {
            return await db.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await db.FindAsync(id);
        }

        private async Task<int> SaveChanges()
        {
            var result = await context.SaveChangesAsync();
            return result;
        }
    }
}
