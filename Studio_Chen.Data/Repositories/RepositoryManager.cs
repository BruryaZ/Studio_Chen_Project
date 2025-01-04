using Studio_Chen.Core.Models;
using Studio_Chen.Data;
using Studio_Chen.Data.Models;
using Studio_Chen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _dataContext;
        public IRepository<Course> CourseRepository { get; }
        public IRepository<Lesson> LessonRepository { get; }
        public IRepository<Teacher> TeacherRepository { get; }
        public IRepository<Gymnast> GymnastRepository { get; }
        public RepositoryManager(DataContext context, IRepository<Course> courses, IRepository<Lesson> lessons, IRepository<Teacher> teachers, IRepository<Gymnast> gymnasts)
        {
            _dataContext = context;
            CourseRepository = courses;
            LessonRepository = lessons;
            TeacherRepository = teachers;
            GymnastRepository = gymnasts;
        }
        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
