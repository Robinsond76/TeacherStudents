using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents(Guid teacherId, bool trackChanges);
        Task<Student> GetStudent(Guid teacherId, Guid id, bool trackChanges);
        void AddStudent(Guid teacherId, Student student);
    }
}
