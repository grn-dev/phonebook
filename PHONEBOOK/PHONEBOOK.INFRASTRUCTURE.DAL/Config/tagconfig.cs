using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Config
{
    public class tagconfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.Title).IsRequired()
                .HasMaxLength(50);
        }
    }
}
