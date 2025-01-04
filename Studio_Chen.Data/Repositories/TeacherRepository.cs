//using Studio_Chen.Core.Repositories;
//using Studio_Chen.Data.Models;
//using Studio_Chen.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Studio_Chen.Data.Repositories
//{
//    public class TeacherRepository : ITeacherRepository
//    {
//        private readonly DataContext _context;
//        public TeacherRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public Teacher Add(Teacher teacher)
//        {
//            _context.Add(teacher);
//            return teacher;
//        }

//        public void Delete(int id)
//        {
//            var existingTeacher = GetById(id);
//            if (existingTeacher is not null)
//                _context.Teacher.Remove(existingTeacher);
//        }

//        public List<Teacher> GetAll()
//        {
//            return _context.Teacher.ToList();
//        }

//        public Teacher? GetById(int id)
//        {
//            return _context.Teacher.FirstOrDefault(x => x.Id == id);
//        }

//        public Teacher Update(Teacher teacher)
//        {
//            var existingTeacher = GetById(teacher.Id);
//            if (existingTeacher is null)
//                throw new Exception("Teacher not found");
//            existingTeacher.Email = teacher.Email;
//            existingTeacher.Address = teacher.Address;
//            existingTeacher.Phone = teacher.Phone;
//            existingTeacher.Lessons = teacher.Lessons;
//            existingTeacher.FirstName = teacher.FirstName;
//            existingTeacher.LastName = teacher.LastName;
//            return existingTeacher;
//        }
//    }
//}
