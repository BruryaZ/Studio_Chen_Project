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
        IEnumerable<Gymnast> GetList();
        Gymnast? GetById(int id);
        Gymnast Add(Gymnast gymnast);
        Gymnast? Update(int id, Gymnast gymnast);
        void Delete(Gymnast gymnast);
    }
}
