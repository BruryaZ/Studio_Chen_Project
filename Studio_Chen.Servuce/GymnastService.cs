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
    public class GymnastService(IRepositoryManager repositoryManager) : IGymnastService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public Gymnast Add(Gymnast gymnast)
        {
            _repositoryManager.GymnastRepository.Add(gymnast);
            this._repositoryManager.Save();
            return gymnast;
        }

        public void Delete(Gymnast gymnast)
        {
            _repositoryManager.GymnastRepository.Delete(gymnast);
            this._repositoryManager.Save();
        }

        public Gymnast? GetById(int id)
        {
            return _repositoryManager.GymnastRepository.GetById(id);
        }

        public IEnumerable<Gymnast> GetList()
        {
            return _repositoryManager.GymnastRepository.GetAll();
        }

        public Gymnast? Update(int id, Gymnast gymnast)
        {
            var dbGymnast = GetById(id);
            if (dbGymnast == null)
            {
                return null;
            }
            dbGymnast.Lessons = gymnast.Lessons;
            dbGymnast.FirstName = gymnast.FirstName;
            dbGymnast.LastName = gymnast.LastName;
            dbGymnast.Phone = gymnast.Phone;
            dbGymnast.Email = gymnast.Email;
            dbGymnast.Address = gymnast.Address;

            _repositoryManager.GymnastRepository.Update(dbGymnast);
            _repositoryManager.Save();
            return dbGymnast;
        }
    }
}