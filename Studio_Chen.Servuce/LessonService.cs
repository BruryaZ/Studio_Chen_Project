using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;

namespace Studio_Chen.Service
{
    public class LessonService : ILessonService
    {
        private readonly IRepositoryManager _repositoryManager;

        public LessonService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Lesson> AddAsync(Lesson lesson)
        {
            await _repositoryManager.LessonRepository.AddAsync(lesson);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
            return lesson;
        }

        public async Task DeleteAsync(Lesson lesson)
        {
            await _repositoryManager.LessonRepository.DeleteAsync(lesson);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
        }

        public async Task<Lesson?> GetByIdAsync(int id)
        {
            return await _repositoryManager.LessonRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Lesson>> GetListAsync()
        {
            return await _repositoryManager.LessonRepository.GetAllAsync();
        }

        public async Task<Lesson?> UpdateAsync(int id, Lesson lesson)
        {
            var dbLesson = await GetByIdAsync(id);
            if (dbLesson == null)
            {
                return null;
            }
            dbLesson.MeetNumber = lesson.MeetNumber;
            dbLesson.EndHour = lesson.EndHour;
            dbLesson.StartHour = lesson.StartHour;
            dbLesson.Date = lesson.Date;
            dbLesson.Course = lesson.Course;
            dbLesson.Teacher = lesson.Teacher;
            dbLesson.Gymnasts = lesson.Gymnasts;

            await _repositoryManager.LessonRepository.UpdateAsync(dbLesson.Id, dbLesson);
            await _repositoryManager.SaveAsync(); // שמירה אסינכרונית
            return dbLesson;
        }
    }
}
