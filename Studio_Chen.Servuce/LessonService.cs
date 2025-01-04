using Studio_Chen.Core.Models;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Studio_Chen.Service
{
    public class LessonService(IRepositoryManager repositoryManager) : ILessonService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public Lesson Add(Lesson lesson)
        {
            _repositoryManager.LessonRepository.Add(lesson);
            this._repositoryManager.Save();
            return lesson;
        }

        public void Delete(Lesson lesson)
        {
            _repositoryManager.LessonRepository.Delete(lesson);
            this._repositoryManager.Save();
        }

        public Lesson? GetById(int id)
        {
            return _repositoryManager.LessonRepository.GetById(id);
        }

        public IEnumerable<Lesson> GetList()
        {
            return _repositoryManager.LessonRepository.GetAll();
        }

        public Lesson? Update(int id, Lesson lesson)
        {
            var dbLesson = GetById(id);
            if (dbLesson == null)
            {
                return null;
            }
            //dbLesson.CourseId = lesson.CourseId;
            dbLesson.MeetNumber = lesson.MeetNumber;
            dbLesson.EndHour = lesson.EndHour;
            dbLesson.StartHour = lesson.StartHour;
            dbLesson.Date = lesson.Date;
            dbLesson.Course = lesson.Course;
            dbLesson.Teacher = lesson.Teacher;
            //dbLesson.TeacherId = lesson.TeacherId;
            dbLesson.Gymnasts = lesson.Gymnasts;

            _repositoryManager.LessonRepository.Update(dbLesson);
            _repositoryManager.Save();
            return dbLesson;
        }
    }
}
