using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Repository
{
    public class PhoneRepo : BaseRepoisitory<Phone>, IPhoneRepository
    {
        public PhoneRepo(PHONEBOOK_DB dbContext):base (dbContext)
        {
            
        }

    }
}
