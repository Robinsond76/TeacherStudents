using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudents
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Teacher, TeacherDto>()
                .ForMember(t => t.Name, option =>
                    option.MapFrom(x => string.Join(" ", x.FirstName, x.LastName)));

            CreateMap<Student, StudentDto>()
                .ForMember(s => s.Name, option =>
                option.MapFrom(x => string.Join(" ", x.FirstName, x.LastName)));
                
        }
    }
}
