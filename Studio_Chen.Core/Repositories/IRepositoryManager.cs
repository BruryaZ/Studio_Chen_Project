using Studio_Chen.Data.Models;
using Studio_Chen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Repositories
{
    public interface IRepositoryManager
    {
        IRepository<Course> CourseRepository { get; }
        IRepository<Gymnast> GymnastRepository { get; }
        IRepository<Lesson> LessonRepository { get; }
        IRepository<Teacher> TeacherRepository { get; }
        void Save();
    }
}