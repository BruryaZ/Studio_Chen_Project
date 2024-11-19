using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Teacher:Person
    {
        public List<Course> courses { get; set; }

        public Teacher(List<Course> courses, string identity, string firstName, string lastName, string phone, string email, string address)
            : base(identity, firstName, lastName, phone, email, address)
        {
            this.courses = courses;
        }

        public Teacher()
        {
        }
    }
}
