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

        public async Task<Student> GetStudent(Guid id, bool trackChanges)
        {
            return await FindByCondition(s => s.Id.Equals(id), trackChanges)
                            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> GetStudents(bool trackChanges)
        {
            return await FindAll(trackChanges)
                            .OrderBy(s => s.FirstName)
                            .ToListAsync();
        }
    }
}
