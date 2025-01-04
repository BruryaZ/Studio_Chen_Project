

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

        public Course Add(Course course)
        {
            _repositoryManager.CourseRepository.Add(course);
            _repositoryManager.Save();
            return course;
        }

        public void Delete(Course course)
        {
            _repositoryManager.CourseRepository.Delete(course);
            this._repositoryManager.Save();
        }

        public Course? GetById(int id)
        {
            return _repositoryManager.CourseRepository.GetById(id);
        }

        public IEnumerable<Course> GetList()
        {
            return _repositoryManager.CourseRepository.GetAll();
        }

        public Course? Update(int id, Course course)
        {
            var dbCourse = GetById(id);
            if (dbCourse == null)
            {
                return null;
            }
            dbCourse.Type = course.Type;
            dbCourse.EndDate = course.EndDate;
            dbCourse.Equipment = course.Equipment;
            dbCourse.Lessons = course.Lessons;
            dbCourse.Type = course.Type;

            _repositoryManager.CourseRepository.Update(dbCourse);
            _repositoryManager.Save();
            return dbCourse;
        }
    }
}