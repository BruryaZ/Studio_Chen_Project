using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Gymnast:Person
    {
        public Gymnast()
        {
        }

        public Gymnast(string identity, string firstName, string lastName, string phone, string email, string address) : base(identity, firstName, lastName, phone, email, address)
        {
        }
    }
}
