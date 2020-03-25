using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.INFRASTRUCTURE.DAL.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL
{
    public class PHONEBOOK_DB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PHONEBOOK;Integrated Security=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new personconfig());
            //modelBuilder.Entity<Department>().ToTable("t_Department");
            modelBuilder.ApplyConfiguration(new PersontagConfig());
            modelBuilder.ApplyConfiguration(new PhoneConfig());
            modelBuilder.ApplyConfiguration(new tagconfig());


            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> people { get; set; }
        public DbSet<PesronTag> PesronTags { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
