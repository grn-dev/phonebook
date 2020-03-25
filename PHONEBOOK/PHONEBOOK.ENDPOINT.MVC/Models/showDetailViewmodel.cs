using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public class showDetail_Viewmodel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public List<Phone> Phones { get; set; }
        public List<PesronTag> Tags { get; set; }

        /////
        

        //
        public List<string> Title_tag { get; set; }
    }
}
