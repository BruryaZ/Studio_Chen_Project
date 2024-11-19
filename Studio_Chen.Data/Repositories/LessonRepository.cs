using Studio_Chen.Core.Repositories;
using Studio_Chen.Data.Models;
using Studio_Chen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Lesson> GetList()
        {
            return _context.LstLesson;
        }
    }
}
