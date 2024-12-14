using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Service
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lesson)
        {
            _lessonRepository = lesson;
        }

        public Lesson Add(Lesson course)
        {
            return _lessonRepository.Add(course);
        }

        public void Delete(int id)
        {
            _lessonRepository.Delete(id);
        }

        public Lesson? GetById(int id)
        {
            return _lessonRepository.GetById(id);
        }

        public List<Lesson> GetList()
        {
            return _lessonRepository.GetAll();
        }

        public Lesson Update(Lesson course)
        {
            return _lessonRepository.Update(course);
        }
    }
}
