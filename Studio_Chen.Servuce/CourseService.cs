using Studio_Chen.Core.Models;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;
using System.Numerics;

namespace Studio_Chen.Service
{
    public class CourseService(IRepositoryManager repositoryManager) : ICourseService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public async Task<Course> AddAsync(Course course)
        {
            _repositoryManager.CourseRepository.AddAsync(course);
            await _repositoryManager.SaveAsync();
            return course;
        }

        public async Task<Course?> GetByIdAsync(int id)
        {
            return await _repositoryManager.CourseRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Course>> GetListAsync()
        {
            return await _repositoryManager.CourseRepository.GetAllAsync();
        }

        public async Task<Course?> UpdateAsync(int id, Course course)
        {
            var dbCourse = GetByIdAsync(id).Result;
            if (dbCourse == null)
            {
                return null;
            }
            dbCourse.Type = course.Type;
            dbCourse.EndDate = course.EndDate;
            dbCourse.Equipment = course.Equipment;
            dbCourse.Lessons = course.Lessons;
            dbCourse.Type = course.Type;

            var result = await _repositoryManager.CourseRepository.UpdateAsync(dbCourse.Id, dbCourse);
            await _repositoryManager.SaveAsync();
            return dbCourse;
        }


        public async Task DeleteAsync(Course course)
        {
            _repositoryManager.CourseRepository.DeleteAsync(course);
            await this._repositoryManager.SaveAsync();
        }
    }
}