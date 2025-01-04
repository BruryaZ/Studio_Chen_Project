using Studio_Chen.Core.Models;
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
        [Key]
        public int Id { get; private set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int MeetNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Gymnast> Gymnasts { get; set; }

        public Lesson( Course course, int courseId, int meetNumber, DateTime date, DateTime startHour, DateTime endHour, int teacherId, Teacher teacher, List<Gymnast> gymnasts)
        {
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
        }
    }
}
