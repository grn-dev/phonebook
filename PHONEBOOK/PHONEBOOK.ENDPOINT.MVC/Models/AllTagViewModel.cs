using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public class AllTagViewModel
    {
        public Tag Title { get; set; }
        public List<Tag> Titles { get; set; }
    }
}
