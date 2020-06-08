//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PHONEBOOK.ENDPOINT.MVC.Models.AAA
{
    public class UserDbContext : IdentityDbContext<Appuser>
    {
        public DbSet<badPasword> BadPasswords { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> option):base(option)
        {

        }
    }

}
