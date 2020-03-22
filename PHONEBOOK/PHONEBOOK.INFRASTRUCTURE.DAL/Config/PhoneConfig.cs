using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Config
{
    public class PhoneConfig : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(c => c.phonenumber).IsRequired();
        }
    }
}
