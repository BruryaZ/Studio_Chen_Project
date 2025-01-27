using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetListAsync();
        Task<Teacher?> GetByIdAsync(int id);
        Task<Teacher> AddAsync(Teacher teacher);
        Task<Teacher?> UpdateAsync(int id, Teacher teacher);
        Task DeleteAsync(Teacher teacher);
    }
}
