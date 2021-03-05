using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ITeacherRepository Teacher { get; }
        IStudentRepository Student { get; }
        Task Save();
    }
}
