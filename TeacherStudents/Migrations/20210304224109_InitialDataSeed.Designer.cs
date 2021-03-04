﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TeacherStudents.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210304224109_InitialDataSeed")]
    partial class InitialDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentId");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("GPA")
                        .HasColumnType("real");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d1fed0f-0e53-4d7e-8b65-896fc8beccf2"),
                            Age = 23,
                            FirstName = "Bella",
                            GPA = 3.6f,
                            LastName = "Garnet",
                            TeacherId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                        },
                        new
                        {
                            Id = new Guid("f884a6ae-e1e6-483b-b7c6-804ad302c551"),
                            Age = 24,
                            FirstName = "Jenni",
                            GPA = 3.7f,
                            LastName = "Brewster",
                            TeacherId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                        },
                        new
                        {
                            Id = new Guid("6cbbd975-8f22-4d52-933d-42d387303626"),
                            Age = 27,
                            FirstName = "Sal",
                            GPA = 3.1f,
                            LastName = "Royce",
                            TeacherId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        });
                });

            modelBuilder.Entity("Entities.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TeacherId");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Age = 29,
                            FirstName = "Colt",
                            LastName = "Steele"
                        },
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Age = 34,
                            FirstName = "Brad",
                            LastName = "Traversy"
                        });
                });

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.HasOne("Entities.Models.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Entities.Models.Teacher", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
