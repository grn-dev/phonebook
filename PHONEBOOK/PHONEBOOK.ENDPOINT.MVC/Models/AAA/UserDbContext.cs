﻿//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PHONEBOOK.ENDPOINT.MVC.Models.AAA
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions option):base(option)
        {

        }
    }

}
