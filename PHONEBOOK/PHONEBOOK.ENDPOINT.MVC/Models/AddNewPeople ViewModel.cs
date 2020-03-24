using Microsoft.AspNetCore.Http;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public abstract class AddNewPeople_ViewModel
    {
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ایمیل واموندتو درست وارد کن پدر سگ!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength:500)]
        public string Address { get; set; }

        [Required]
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