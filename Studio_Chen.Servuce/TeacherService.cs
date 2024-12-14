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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacher)
        {
            _teacherRepository = teacher;
        }

        public Teacher Add(Teacher course)
        {
            return _teacherRepository.Add(course);
        }

        public void Delete(int id)
        {
            _teacherRepository.Delete(id);
        }

        public Teacher? GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public List<Teacher> GetList()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher Update(Teacher course)
        {
            return _teacherRepository.Update(course);
        }
    }
}