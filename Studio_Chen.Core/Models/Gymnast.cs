using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Gymnast : Person
    {
        private static int count = 1;
        //[Key]
        public int Id { get; private set; }
        public List<Lesson> lessons { get; set; }
        public Gymnast()
        {
            Id = count++;
        }

        public Gymnast(List<Lesson> lessons, string identity, string firstName, string lastName, string phone, string email, string address) : base(identity, firstName, lastName, phone, email, address)
        {
            Id = count++;
            this.lessons = lessons;
        }

    }
}
