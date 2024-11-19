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
        public List<Lesson> GetAll()
        {
            return _lessonRepository.GetList();
        }
    }
}
