using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FreeTime.Common.Models;

namespace FreeTime.Common.Repositories
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepo()
        {
            context = new ApplicationDbContext();
            dbSet = context.Set<TEntity>();
        }

        public GenericRepo(ApplicationDbContext ctx)
        {
            context = ctx;
            dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> All()
        {
            return dbSet;
        }

        public void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            return dbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}