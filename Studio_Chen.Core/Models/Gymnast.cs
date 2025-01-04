using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Models
{
    public class Gymnast : Person
    {
        [Key] 
        public int Id { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Gymnast()
        {
        }
        public Gymnast(List<Lesson> lessons, string identity, string firstName, string lastName, string phone, string email, string address) : base(identity, firstName, lastName, phone, email, address)
        {
            this.Lessons = lessons;
        }
    }
}
