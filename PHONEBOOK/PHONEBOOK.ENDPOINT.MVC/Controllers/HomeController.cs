using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.ENDPOINT.MVC.Models;
using PHONEBOOK.INFRASTRUCTURE.DAL;

namespace PHONEBOOK.ENDPOINT.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PHONEBOOK_DB cnx = new PHONEBOOK_DB();

            Person people = new Person() {
                FirstName = "mahmoud",
                LastName = "sabzali",
                Address = "afsarey",
                Image = "imagegrn",
                Email= "sabzali@gmail.com"

            };

            cnx.people.Add(people);
              cnx.SaveChanges();

            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
