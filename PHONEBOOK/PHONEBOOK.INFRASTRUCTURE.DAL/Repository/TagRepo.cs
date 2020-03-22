using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Repository
{
    public class TagRepo : BaseRepoisitory<Tag>, ITagRepository
    {
        public TagRepo(PHONEBOOK_DB dbContext) : base(dbContext)
        {

        }
    }
}
