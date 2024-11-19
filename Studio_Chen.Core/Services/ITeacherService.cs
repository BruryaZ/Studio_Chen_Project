using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
    }
}
