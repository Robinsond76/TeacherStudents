using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private ITeacherRepository _teacherRepository;
        private IStudentRepository _studentRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ITeacherRepository Teacher
        {
            get
            {
                if (_teacherRepository == null)
                    _teacherRepository = new TeacherRepository(_repositoryContext);

                return _teacherRepository;
            }
        }

        public IStudentRepository Student
        {
            get
            {
                if (_studentRepository == null)
                    _studentRepository = new StudentRepository(_repositoryContext);

                return _studentRepository;
            }
        }

        public async Task Save()
        {
           await _repositoryContext.SaveChangesAsync();
        }
    }
}
