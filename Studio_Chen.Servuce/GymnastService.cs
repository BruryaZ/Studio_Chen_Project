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
        public List<Gymnast> GetAll()
        {
            return _gymnastRepository.GetList();
        }
    }
}