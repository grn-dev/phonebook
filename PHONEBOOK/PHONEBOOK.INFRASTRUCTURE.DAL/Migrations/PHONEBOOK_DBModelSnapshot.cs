﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PHONEBOOK.INFRASTRUCTURE.DAL;

namespace PHONEBOOK.INFRASTRUCTURE.DAL.Migrations
{
    [DbContext(typeof(PHONEBOOK_DB))]
    partial class PHONEBOOK_DBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("tbl_Person");
                });

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.PesronTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("personid")
                        .HasColumnType("int");

                    b.Property<int>("tagid")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("personid");

                    b.HasIndex("tagid");

                    b.ToTable("PesronTags");
                });

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.Phone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonID")
                        .HasColumnType("int");

                    b.Property<int>("TypePhone")
                        .HasColumnType("int");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.PesronTag", b =>
                {
                    b.HasOne("PHONEBOOK.DOMIN.CORE.Person", "person")
                        .WithMany("Tags")
                        .HasForeignKey("personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PHONEBOOK.DOMIN.CORE.Tag", "tag")
                        .WithMany()
                        .HasForeignKey("tagid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PHONEBOOK.DOMIN.CORE.Phone", b =>
                {
                    b.HasOne("PHONEBOOK.DOMIN.CORE.Person", null)
                        .WithMany("Phones")
                        .HasForeignKey("PersonID");
                });
#pragma warning restore 612, 618
        }
    }
}
