using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ILessonService
    {
        IEnumerable<Lesson> GetList();
        Lesson? GetById(int id);
        Lesson Add(Lesson course);
        Lesson? Update(int id, Lesson course);
        void Delete(Lesson lesson);
    }
}
