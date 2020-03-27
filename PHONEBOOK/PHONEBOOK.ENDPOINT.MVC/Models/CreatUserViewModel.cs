using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHONEBOOK.ENDPOINT.MVC.Models
{
    public class CreatUserViewModel
    {
        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [Required]
        [MaxLength(050)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string password { get; set; }
        
    }
}
