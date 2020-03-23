using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;


namespace PHONEBOOK.INFRASTRUCTURE.DAL.Config
{
    public class personconfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tbl_Person");
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.LastName).HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().IsUnicode(false).HasMaxLength(250);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Image).HasMaxLength(50);

        }
    }
}
