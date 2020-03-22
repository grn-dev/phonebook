using Microsoft.AspNetCore.Http;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public abstract class AddNewPeople_ViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public IFormFile Image { get; set; }
        //public List<Phone> Phones { get; set; }
        
        
    }

    public  class AddNewPeopleForDispaly_ViewModel : AddNewPeople_ViewModel
    {
        public List<Tag> TagsForDisplay { get; set; }
    }

    public  class AddNewPeopleselectedTag_ViewModel: AddNewPeople_ViewModel
    {
        public List<Tag> selectedtag { get; set; }
    }

}