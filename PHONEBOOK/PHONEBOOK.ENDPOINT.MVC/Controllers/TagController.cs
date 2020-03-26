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
    public class TagController : Controller
    {

        private readonly ITagRepository tagRepository;
        private readonly IPersonRepository personRepository;
        public TagController(ITagRepository _tagRepository, IPersonRepository _personRepository)
        {
            tagRepository = _tagRepository;
            personRepository = _personRepository;
        }
        public IActionResult Index()
        {
            var alltag = tagRepository.GetAll().ToList();
            AllTagViewModel ssss = new AllTagViewModel()
            {
                Titles = alltag,
            };
            
            return View(ssss);
        }

        public IActionResult update(int id)
        {
            
            var gkjg=tagRepository.getByID(id);
            return View("Menu", gkjg);
           // return View(gkjg);
        }


        public IActionResult Delete(int id)
        {
            tagRepository.Delete(id);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Add(AllTagViewModelforsave ssss)
        {

            Tag alo = new Tag() { 
            Title= ssss.Title
            };
            //ssss.Title
            tagRepository.Add(alo);
               

            return RedirectToAction("Index");
        }
    }
}