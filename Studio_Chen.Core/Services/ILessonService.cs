using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ILessonService
    {
        Task<IEnumerable<Lesson>> GetListAsync();
        Task<Lesson?> GetByIdAsync(int id);
        Task<Lesson> AddAsync(Lesson lesson);
        Task<Lesson?> UpdateAsync(int id, Lesson lesson);
        Task DeleteAsync(Lesson lesson);
    }
}
