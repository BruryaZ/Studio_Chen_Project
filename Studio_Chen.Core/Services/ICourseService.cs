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
        List<Course> GetList();
        Course? GetById(int id);
        Course Add(Course course);
        Course Update(Course course);
        void Delete(int id);
    }
}
