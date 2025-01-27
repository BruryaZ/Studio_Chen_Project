using Studio_Chen.Core.Models;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio_Chen.Service
{
    public class GymnastService : IGymnastService
    {
        private readonly IRepositoryManager _repositoryManager;

        public GymnastService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Gymnast> AddAsync(Gymnast gymnast)
        {
            await _repositoryManager.GymnastRepository.AddAsync(gymnast);
            await _repositoryManager.SaveAsync(); 
            return gymnast;
        }

        public async Task DeleteAsync(Gymnast gymnast)
        {
            await _repositoryManager.GymnastRepository.DeleteAsync(gymnast);
            await _repositoryManager.SaveAsync();
        }

        public async Task<Gymnast?> GetByIdAsync(int id)
        {
            return await _repositoryManager.GymnastRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Gymnast>> GetListAsync()
        {
            return await _repositoryManager.GymnastRepository.GetAllAsync();
        }

        public async Task<Gymnast?> UpdateAsync(int id, Gymnast gymnast)
        {
            var dbGymnast = await GetByIdAsync(id);
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

            await _repositoryManager.GymnastRepository.UpdateAsync(dbGymnast.Id, dbGymnast);
            await _repositoryManager.SaveAsync(); 
            return dbGymnast;
        }
    }
}