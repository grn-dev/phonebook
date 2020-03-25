using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PHONEBOOK.DOMIN.CORE;
using PHONEBOOK.INFRASTRUCTURE.DAL.Repository;
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

            /*using (PHONEBOOK_DB ctx = new PHONEBOOK_DB())
            {
                var peron = new PersonRepo(ctx);

                var Pesron_Tag = new BaseRepoisitory<PersontagConfig>(ctx);
                var tagg = new BaseRepoisitory> (ctx);

                var studentToStandard = studentRep.GetAll().Join(standardRep.GetAll(),
                                      student => student.StandardRefId,
                                      standard => standard.StandardId,
                                      (stud, stand) => new { Student = stud, Standard = stand }).ToList();
            }*/
        }
    }
}
