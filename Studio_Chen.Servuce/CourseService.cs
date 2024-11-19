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
        public List<Course> GetAll()
        {
            return _courseRepository.GetList();
        }
    }
}