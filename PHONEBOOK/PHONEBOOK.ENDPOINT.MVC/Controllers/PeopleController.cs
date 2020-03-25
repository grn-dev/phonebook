using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHONEBOOK.DOMAIN.CONTRACT;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.ENDPOINT.MVC.Models;
using PHONEBOOK.INFRASTRUCTURE.DAL;
using PHONEBOOK.INFRASTRUCTURE.DAL.Repository;
using static System.Net.Mime.MediaTypeNames;

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
            var listprsn = personRepository.GetAll().ToList();
            return View(listprsn);
        }

        /*public IActionResult showDetial(int id)
        {
            var customer = (
            from cus in personRepository.GetAll()
            join lib in tagRepository.GetAll()
            join lib in tagRepository.GetAll()
            on cus.ID equals lib.
            select cus
                ).ToList();

            var pr = personRepository.getByID(id);
            showDetail_Viewmodel mdlshow = new showDetail_Viewmodel()
            {
                FirstName = pr.FirstName,
                LastName = pr.LastName,
                Address = pr.Address,
                Email = pr.Email,
                Phones = pr.Phones,
                //Image= pr.Image,
                Tags = pr.Tags,

            };
            var pr = PesronTag.;
            mdlshow.Title_tag =

            byte[] bytes = Convert.FromBase64String("");

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            //     [HttpPost]

            
        //return View(listprsn);
    }*/

    public void Base64ToImage(string _source)
        {
            string source = _source;
            string base64 = source.Substring(source.IndexOf(',') + 1);
            byte[] data = Convert.FromBase64String(base64);
        }

        /*public Image LoadImage(string _source)
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(_source);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }*/


        // by default get
        public IActionResult Add()
        {
            AddNewPeopleForDispaly_ViewModel model = new AddNewPeopleForDispaly_ViewModel();
            //Tag ssss = new Tag();
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
                Person prsn = new Person()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Email = model.Email,

                    //Tags = new List<PesronTag>(model.selectedtag.Select(c => new PesronTag))
                    //{
                    //  unselect after 
                    //},

                    //Tags = new List<PesronTag>(model.selectedtag.Select(c => new PesronTag
                    //{
                    //    tagid = c
                    //}).ToList())

                };
                if (model?.Image?.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        prsn.Image = Convert.ToBase64String(fileBytes);
                    }
                }


                personRepository.Add(prsn);

                return View();//null renrence

            }
            AddNewPeopleForDispaly_ViewModel modelshow = new AddNewPeopleForDispaly_ViewModel()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Address = model.Address,
            };
            modelshow.TagsForDisplay = tagRepository.GetAll().ToList();//show un selct 
            return View(modelshow);
        }







    }
}
