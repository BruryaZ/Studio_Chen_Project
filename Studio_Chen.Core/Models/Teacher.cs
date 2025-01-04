using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Teacher : Person
    {
        [Key]
        public int Id { get; private set; }
        public List<Lesson> Lessons { get; set; }

        public Teacher(List<Lesson> lessons, string identity, string firstName, string lastName, string phone, string email, string address) : base(identity, firstName, lastName, phone, email, address)
        {
            Lessons = lessons;
        }

        public Teacher()
        {
        }
    }
}