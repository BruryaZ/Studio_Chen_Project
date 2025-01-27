using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio_Chen.Data.MockData
{
    public class FakeTeacherService : ITeacherService
    {
        private readonly FakeData _fakeData;

        public FakeTeacherService()
        {
            _fakeData = new FakeData();
        }

        public Task<IEnumerable<Teacher>> GetListAsync()
        {
            return Task.FromResult<IEnumerable<Teacher>>(_fakeData.LstTeacher);
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            var teacher = _fakeData.LstTeacher.FirstOrDefault(t => t.Identity == id.ToString());
            return Task.FromResult(teacher);
        }

        public Task<Teacher> AddAsync(Teacher teacher)
        {
            _fakeData.LstTeacher.Add(teacher);
            return Task.FromResult(teacher);
        }

        public Task<Teacher> UpdateAsync(int id, Teacher teacher)
        {
            var existingTeacher = _fakeData.LstTeacher.FirstOrDefault(t => t.Identity == id.ToString());
            if (existingTeacher != null)
            {
                existingTeacher.FirstName = teacher.FirstName;
                existingTeacher.LastName = teacher.LastName;
                // עדכן שדות נוספים כנדרש
            }
            return Task.FromResult(existingTeacher);
        }

        public Task DeleteAsync(Teacher teacher)
        {
            _fakeData.LstTeacher.Remove(teacher);
            return Task.CompletedTask;
        }
    }
}