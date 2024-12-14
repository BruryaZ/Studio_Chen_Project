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
    public class GymnastService : IGymnastService
    {
        private readonly IGymnastRepository _gymnastRepository;
        public GymnastService(IGymnastRepository gymnast)
        {
            _gymnastRepository = gymnast;
        }

        public Gymnast Add(Gymnast course)
        {
            return _gymnastRepository.Add(course);
        }

        public void Delete(int id)
        {
            _gymnastRepository.Delete(id);
        }

        public Gymnast? GetById(int id)
        {
            return _gymnastRepository.GetById(id);
        }

        public List<Gymnast> GetList()
        {
            return _gymnastRepository.GetAll();
        }

        public Gymnast Update(Gymnast course)
        {
            return _gymnastRepository.Update(course);
        }
    }
}