using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PHONEBOOK.DOMIN.CORE;
using System;
using System.Collections.Generic;
using System.Text;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Config
{
    public class PersontagConfig : IEntityTypeConfiguration<PesronTag>
    {
        

        public void Configure(EntityTypeBuilder<PesronTag> builder)
        {

            builder.Property(c => c.ID).IsRequired();
        }
    }
}
