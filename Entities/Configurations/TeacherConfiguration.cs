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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
                (
                    new Teacher
                    {
                        Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        FirstName = "Colt",
                        LastName = "Steele",
                        Age = 29
                    },
                    new Teacher
                    {
                        Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                        FirstName = "Brad",
                        LastName ="Traversy",
                        Age = 34
                    }
                );
        }
    }
}
