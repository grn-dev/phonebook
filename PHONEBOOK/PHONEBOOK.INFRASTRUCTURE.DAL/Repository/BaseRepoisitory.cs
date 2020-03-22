using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Repository
{
    public abstract class BaseRepoisitory<TEntity> : IBaserepositori<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly PHONEBOOK_DB context;
        public BaseRepoisitory(PHONEBOOK_DB pHONEBOOK_)
        {
            context = pHONEBOOK_;
        }

        public void Add(TEntity entity)
        {
            /*dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
            return entity;*/

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            //return entity;

        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                ID = id
            };
            context.Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsQueryable();
        }

        public TEntity getByID(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
    }
}
