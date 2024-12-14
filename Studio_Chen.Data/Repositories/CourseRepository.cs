using Microsoft.EntityFrameworkCore;
using Studio_Chen.Data.Models;
using Studio_Chen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public Course Add(Course course)
        {
            _context.Add(course);
            return course;
        }

        public void Delete(int id)
        {
            var existingCourse = GetById(id);
            if (existingCourse is not null)
                _context.Courses.Remove(existingCourse);
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course? GetById(int id)
        {
            return _context.Courses.FirstOrDefault(x => x.Identity == id);
        }

        public Course Update(Course course)
        {
            var existingCourse = GetById(course.Identity);
            if (existingCourse is null)
                throw new Exception("Course not found");
            existingCourse.StartDate = course.StartDate;
            existingCourse.EndDate = course.EndDate;
            existingCourse.MeetsNumber = course.MeetsNumber;
            existingCourse.Lessons = course.Lessons;
            existingCourse.Equipment = course.Equipment;
            existingCourse.Type = course.Type;
            return existingCourse;
        }
    }
}