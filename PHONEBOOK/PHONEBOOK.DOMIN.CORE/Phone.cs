using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.DOMIN.CORE
{
    public class Phone:BaseEntity
    {
        public PhoneType TypePhone { get; set; }
        public string phonenumber { get; set; }
    }
}
