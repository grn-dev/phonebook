using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.DOMAIN.CONTRACT
{
    public interface IPersonRepository  : IBaserepositori<Person>
    {
        //IQueryable<TEntity> GetAll();
        ICollection<TEntity> GetpersonAndTag(int personId);
        //ICollection

    }
}
