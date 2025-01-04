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

namespace Studio_Chen.Service
{
    public class TeacherService(IRepositoryManager repositoryManager) : ITeacherService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public Teacher Add(Teacher teacher)
        {
            _repositoryManager.TeacherRepository.Add(teacher);
            this._repositoryManager.Save();
            return teacher;
        }

        public void Delete(Teacher teacher)
        {
            _repositoryManager.TeacherRepository.Delete(teacher);
            this._repositoryManager.Save();
        }

        public Teacher? GetById(int id)
        {
            return _repositoryManager.TeacherRepository.GetById(id);
        }

        public IEnumerable<Teacher> GetList()
        {
            return _repositoryManager.TeacherRepository.GetAll();
        }

        public Teacher? Update(int id, Teacher teacher)
        {
            var dbTeacher = GetById(id);
            if (dbTeacher == null)
            {
                return null;
            }
            dbTeacher.Lessons = teacher.Lessons;
            dbTeacher.FirstName = teacher.FirstName;
            dbTeacher.LastName = teacher.LastName;
            dbTeacher.Phone = teacher.Phone;
            dbTeacher.Email = teacher.Email;
            dbTeacher.Address = teacher.Address;

            _repositoryManager.TeacherRepository.Update(dbTeacher);
            _repositoryManager.Save();
            return dbTeacher;
        }
    }
}