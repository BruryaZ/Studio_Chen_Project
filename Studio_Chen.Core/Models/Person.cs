using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Person
    {
        static int count = 1;
        private int id;

        public int Id
        {
            get { return id; }
        }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(string identity, string firstName, string lastName, string phone, string email, string address)
        {
            id = count++;
            Identity = identity;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Person()
        {
            id = count++;
        }
    }
}
