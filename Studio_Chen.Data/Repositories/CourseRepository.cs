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
        public List<Course> GetList()
        {
            return _context.LstCourses;
        }
    }
}