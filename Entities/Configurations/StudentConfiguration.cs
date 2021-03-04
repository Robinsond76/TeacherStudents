using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                    new Student
                    {
                        Id = new Guid("9d1fed0f-0e53-4d7e-8b65-896fc8beccf2"),
                        FirstName = "Bella",
                        LastName = "Garnet",
                        Age = 23,
                        GPA = 3.6F,
                        TeacherId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new Student
                    {
                        Id = new Guid("f884a6ae-e1e6-483b-b7c6-804ad302c551"),
                        FirstName = "Jenni",
                        LastName = "Brewster",
                        Age = 24,
                        GPA = 3.7F,
                        TeacherId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new Student
                    {
                        Id = new Guid("6cbbd975-8f22-4d52-933d-42d387303626"),
                        FirstName = "Sal",
                        LastName = "Royce",
                        Age = 27,
                        GPA = 3.1F,
                        TeacherId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                    }
                );
        }
    }
}
