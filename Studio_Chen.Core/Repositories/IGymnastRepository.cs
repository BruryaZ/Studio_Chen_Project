using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Repositories
{
    public interface IGymnastRepository
    {
        List<Gymnast> GetAll();
        Gymnast? GetById(int id);
        Gymnast Add(Gymnast course);
        Gymnast Update(Gymnast course);
        void Delete(int id);
    }
}
