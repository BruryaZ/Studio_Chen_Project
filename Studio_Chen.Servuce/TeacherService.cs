using Studio_Chen.Core.Models;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio_Chen.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TeacherService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Teacher> AddAsync(Teacher teacher)
        {
            await _repositoryManager.TeacherRepository.AddAsync(teacher);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
            return teacher;
        }

        public async Task DeleteAsync(Teacher teacher)
        {
            await _repositoryManager.TeacherRepository.DeleteAsync(teacher);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _repositoryManager.TeacherRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Teacher>> GetListAsync()
        {
            return await _repositoryManager.TeacherRepository.GetAllAsync();
        }

        public async Task<Teacher?> UpdateAsync(int id, Teacher teacher)
        {
            var dbTeacher = await GetByIdAsync(id);
            if (dbTeacher == null)
            {
                return null;
            }
            dbTeacher.Lessons = teacher.Lessons;
            dbTeacher.FirstName = teacher.FirstName;
            dbTeacher.LastName = teacher.LastName;
            dbTeacher.Phone = teacher.Phone;
            dbTeacher.Email = teacher.Email;
            dbTeacher.Address = teacher.Address;

            await _repositoryManager.TeacherRepository.UpdateAsync(dbTeacher.Id, dbTeacher);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
            return dbTeacher;
        }
    }
}
