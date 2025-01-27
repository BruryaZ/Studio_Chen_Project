using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface IGymnastService
    {
        Task<IEnumerable<Gymnast>> GetListAsync();
        Task<Gymnast?> GetByIdAsync(int id);
        Task<Gymnast> AddAsync(Gymnast gymnast);
        Task<Gymnast?> UpdateAsync(int id, Gymnast gymnast);
        Task DeleteAsync(Gymnast gymnast);
    }
}
