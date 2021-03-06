﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<Teacher>> GetAllTeachers(bool trackChanges);
        Task<Teacher> GetTeacher(Guid id, bool trackChanges);
        void AddTeacher(Teacher teacher);
    }
}
