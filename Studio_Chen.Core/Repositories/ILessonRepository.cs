using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Repositories
{
    public interface ILessonRepository
    {
        List<Lesson> GetAll();
        Lesson? GetById(int id);
        Lesson Add(Lesson course);
        Lesson Update(Lesson course);
        void Delete(int id);
    }
}
