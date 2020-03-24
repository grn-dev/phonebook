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
        private readonly ITagRepository tagRepository;
        private readonly IPersonRepository personRepository;
        public PeopleController(ITagRepository _tagRepository, IPersonRepository _personRepository)
        {
            tagRepository = _tagRepository;
            personRepository = _personRepository;
        }
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
            //PHONEBOOK_DB dbContext = new PHONEBOOK_DB();
            //dbContext
            //TagRepo ssd = new TagRepo(dbContext);
            // model.TagsForDisplay = ssd.GetAll().ToList();
            model.TagsForDisplay = tagRepository.GetAll().ToList();
            return View(model);
        }



        [HttpPost]
        public IActionResult Add(AddNewPeopleselectedTag_ViewModel model)
        {
            if (ModelState.IsValid)
            {
                Person p = new Person()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Email = model.Email,

                    //Tags = new List<PesronTag>(model.selectedtag.Select(c=> new PesronTag))
                    //{

                    //},
                    Image = model.FirstName,



                };


                personRepository.Add(p);
                return View();

            }
            return View(model);
        }







    }
}
