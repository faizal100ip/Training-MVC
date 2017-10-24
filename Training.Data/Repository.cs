using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Training.Model;

namespace Training.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IDbContext Context;

        private IDbSet<TEntity> Entities
        {
            get { return this.Context.Set<TEntity>(); }
        }

        public EfRepository(IDbContext context)
        {
            this.Context = context;

        }

        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }

        public TEntity GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(TEntity entity)
        {
            Entities.Add(entity);
            this.Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Entities.Remove(entity);
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }
        }


    }
}
