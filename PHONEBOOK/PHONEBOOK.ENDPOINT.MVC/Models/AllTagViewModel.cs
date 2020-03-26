using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public class AllTagViewModel
    {
        
        public List<Tag> Titles { get; set; }
    }

    public class AllTagViewModelforsave
    {
        public string Title { get; set; }
         
    }
}
