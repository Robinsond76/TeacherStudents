﻿using Contracts;
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
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddTeacher(Teacher teacher)
        {
            Create(teacher);
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers(bool trackChanges)
        {
            return await FindAll(trackChanges)
                            .OrderBy(t => t.FirstName)
                            .ToListAsync();
        }

        public async Task<Teacher> GetTeacher(Guid id, bool trackChanges)
        {
            return await FindByCondition(t => t.Id.Equals(id), trackChanges)
                    .SingleOrDefaultAsync();
        }
    }
}
