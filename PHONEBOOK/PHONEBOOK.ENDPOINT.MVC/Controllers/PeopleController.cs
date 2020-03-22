using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.ENDPOINT.MVC.Models;

namespace PHONEBOOK.ENDPOINT.MVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        // by default get
        public IActionResult Add()
        {
            AddNewPeopleForDispaly_ViewModel model = new AddNewPeopleForDispaly_ViewModel();
            //model.TagsForDisplay = ITagRepository;
            return View();
        }



        [HttpPost]
        public IActionResult Add(Person person)
        {
            return View();
        }





    }
}
