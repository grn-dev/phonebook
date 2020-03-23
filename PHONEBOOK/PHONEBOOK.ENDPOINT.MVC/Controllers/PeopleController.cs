using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.ENDPOINT.MVC.Models;
using PHONEBOOK.INFRASTRUCTURE.DAL;
using PHONEBOOK.INFRASTRUCTURE.DAL.Repository;

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
            Tag ssss = new Tag();
            PHONEBOOK_DB dbContext=new PHONEBOOK_DB();
            //dbContext
            TagRepo ssd = new TagRepo(dbContext);
            model.TagsForDisplay = ssd.GetAll().ToList();
            //model.TagsForDisplay = TagRepo.GetAll().ToList();
            return View();
        }



        [HttpPost]
        public IActionResult Add(AddNewPeopleselectedTag_ViewModel person)
        {
            return View();
        }





    }
}
