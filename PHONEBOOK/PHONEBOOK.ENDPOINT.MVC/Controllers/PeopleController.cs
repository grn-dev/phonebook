using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHONEBOOK.DOMIN.CORE;

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
            return View();
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            return View();
        }





    }
}
