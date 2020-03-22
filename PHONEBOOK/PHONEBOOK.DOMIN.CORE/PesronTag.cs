using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.DOMIN.CORE
{
    public class PesronTag:BaseEntity
    {
        public int personid { get; set; }
        public Person person { get; set; }
        public int tagid{ get; set; }
        public Tag tag { get; set; }
    }
}
