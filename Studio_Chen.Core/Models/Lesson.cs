using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Data.Models
{
    public class Lesson
    {
        static int count = 1;
        [Key]
        public int Identity { get; private set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public int MeetNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Gymnast> Gymnasts { get; set; }

        public Lesson(int identity, Course course, string courseId, int meetNumber, DateTime date, DateTime startHour, DateTime endHour, int teacherId, Teacher teacher, List<Gymnast> gymnasts)
        {
            Identity = identity;
            Course = course;
            CourseId = courseId;
            MeetNumber = meetNumber;
            Date = date;
            StartHour = startHour;
            EndHour = endHour;
            TeacherId = teacherId;
            Teacher = teacher;
            Gymnasts = gymnasts;
        }

        public Lesson()
        {
            Identity = count++;
        }
    }
}
