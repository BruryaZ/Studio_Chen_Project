using Studio_Chen.Data.Models;
using Studio_Chen.Data.Repositories;
using Studio_Chen.Service.Services;

namespace Studio_Chen.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository course)
        {
            _courseRepository = course;
        }

        public Course Add(Course course)
        {
            return _courseRepository.Add(course);

        }

        public void Delete(int id)
        {
            _courseRepository.Delete(id);
        }

        public Course? GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public List<Course> GetList()
        {
            return _courseRepository.GetAll();
        }

        public Course Update(Course course)
        {
            return _courseRepository.Update(course);
        }
    }
}