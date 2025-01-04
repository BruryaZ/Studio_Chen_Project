//using Studio_Chen.Core.Models;
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
//    public class GymnastRepository : IGymnastRepository
//    {
//        private readonly DataContext _context;
//        public GymnastRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public Gymnast Add(Gymnast gymnast)
//        {
//            _context.Add(gymnast);
//            return gymnast;
//        }

//        public void Delete(int id)
//        {
//            var existingGymnast = GetById(id);
//            if (existingGymnast is not null)
//                _context.Gymnast.Remove(existingGymnast);
//        }

//        public List<Gymnast> GetAll()
//        {
//            return _context.Gymnast.ToList();
//        }

//        public Gymnast? GetById(int id)
//        {
//            return _context.Gymnast.FirstOrDefault(x => x.Id == id);
//        }

//        public Gymnast Update(Gymnast gymnast)
//        {
//            var existingGymnast = GetById(gymnast.Id);
//            if (existingGymnast is null)
//                throw new Exception("Lesson not found");
//            existingGymnast.lessons = gymnast.lessons;
//            existingGymnast.Address = gymnast.Address;
//            existingGymnast.FirstName = gymnast.FirstName;
//            existingGymnast.LastName = gymnast.LastName;
//            existingGymnast.Email = gymnast.Email;
//            existingGymnast.Phone = gymnast.Phone;
//            return existingGymnast;
//        }
//    }
//}