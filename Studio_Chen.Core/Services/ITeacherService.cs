using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetList();
        Teacher? GetById(int id);
        Teacher Add(Teacher course);
        Teacher Update(Teacher course);
        void Delete(int id);
    }
}
