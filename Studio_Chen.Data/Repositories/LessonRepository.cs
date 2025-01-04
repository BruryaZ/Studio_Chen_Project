//using Microsoft.EntityFrameworkCore;
//using Studio_Chen.Core.Repositories;
//using Studio_Chen.Data.Models;
//using Studio_Chen.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Studio_Chen.Data.Repositories
//{
//    public class LessonRepository : ILessonRepository
//    {
//        private readonly DataContext _context;
//        public LessonRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public Lesson Add(Lesson lesson)
//        {
//            _context.Add(lesson);
//            return lesson;
//        }

//        public void Delete(int id)
//        {
//            var existingLesson = GetById(id);
//            if (existingLesson is not null)
//                _context.Lesson.Remove(existingLesson);
//        }

//        public List<Lesson> GetAll()
//        {
//            return _context.Lesson.ToList();
//        }

//        public Lesson? GetById(int id)
//        {
//            return _context.Lesson.FirstOrDefault(x => x.Identity == id);
//        }

//        public Lesson Update(Lesson lesson)
//        {
//            var existingLesson = GetById(lesson.Identity);
//            if (existingLesson is null)
//                throw new Exception("Lesson not found");
//            existingLesson.StartHour = lesson.StartHour;
//            existingLesson.Teacher  = lesson.Teacher;
//            existingLesson.MeetNumber = lesson.MeetNumber;
//            existingLesson.Course = lesson.Course;
//            existingLesson.CourseId = lesson.CourseId;
//            existingLesson.Date = lesson.Date;
//            existingLesson.EndHour = lesson.EndHour;
//            existingLesson.Teacher = lesson.Teacher;
//            existingLesson.TeacherId = lesson.TeacherId;
//            return existingLesson;
//        }
//    }
//}