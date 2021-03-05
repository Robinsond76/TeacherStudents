using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddStudent(Guid teacherId, Student student)
        {
            student.TeacherId = teacherId;
            Create(student);
        }

        public async Task<Student> GetStudent(Guid teacherId, Guid id, bool trackChanges)
        {
            return await FindByCondition(s => s.TeacherId.Equals(teacherId) 
                                              && s.Id.Equals(id), trackChanges)
                            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> GetStudents(Guid teacherId, bool trackChanges)
        {
            return await FindByCondition(s => s.TeacherId.Equals(teacherId), trackChanges)
                            .OrderBy(s => s.FirstName)
                            .ToListAsync();
        }
    }
}
