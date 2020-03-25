using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Repository
{
    public class PersonRepo : BaseRepoisitory<Person>, IPersonRepository   
    {
        public PersonRepo(PHONEBOOK_DB dbContext) : base(dbContext)
        {
            
        }
    }
}
