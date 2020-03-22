using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PHONEBOOK.DOMAIN.CONTRACT
{
    public interface IBaserepositori <TEntity> where TEntity: BaseEntity,new()
    {

        void Add(TEntity entity);
        //List<TEntity> getAll();
        IQueryable<TEntity> GetAll();
        TEntity getByID(int id);
        void Delete(int id);
        

        //public <TEntity> getID(<TEntity> TEntity);

        



    }
}
