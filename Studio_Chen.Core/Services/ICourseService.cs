using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Service.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetListAsync();
        Task<Course?> GetByIdAsync(int id);
        Task<Course> AddAsync(Course course);
        Task<Course?> UpdateAsync(int id, Course course);
        Task DeleteAsync(Course course);
    }
}
