using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PHONEBOOK.ENDPOINT.MVC.Models;
using PHONEBOOK.ENDPOINT.MVC.Models.AAA;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PHONEBOOK.ENDPOINT.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<Appuser> UserManager;
        public UserController(UserManager<Appuser> user)
        {
            this.UserManager = user;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var user = UserManager.Users.Take(20).ToList();
            return View(user);
        }

        public IActionResult Creat()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Creat(CreatUserViewModel model)
        {
            string Errortxt = null;
            if (ModelState.IsValid)
            {
                Appuser user = new Appuser();
                user.UserName = model.username;
                // user.PasswordHash = model.username;
                user.Email = model.Email;


                //.resule وایمیسته تا نتیجه بیاد
                var save = UserManager.CreateAsync(user, model.username).Result;

                if (save.Succeeded) {
                    return RedirectToAction("Index");
                }
                else {
                    foreach (var item in save.Errors)
                    {
                        Errortxt = Errortxt + "          " + item.Description;
                        ModelState.AddModelError(item.Code,item.Description);
                    }
                }
                 

                ViewBag.Error = Errortxt;
                //UserManager.add
                //repoditory or savind here

            }
            else {
                
                return View(model);
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var user = UserManager.FindByIdAsync(id.ToString()).Result;
            if (user != null)
            {
                UpdateUserViewModel model = new UpdateUserViewModel
                {
                    Email = user.Email
                };
                return View(user);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Update(int id, UpdateUserViewModel updateUserViewModel)
        {
            var user = UserManager.FindByIdAsync(id.ToString()).Result;
            if (user != null)
            {
                user.Email = updateUserViewModel.Email;
                var result = UserManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.Code, item.Description);
                    }
                }
                return View(updateUserViewModel);
            }
            return NotFound();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
