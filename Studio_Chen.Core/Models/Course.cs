using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Models
{
    public enum ETypeOfCourse { pilates, design_and_toning, Aerobics_band_dynamic_design, floor_exercise, ballet, dance }
    public class Course
    {
        [Key]
        public int Id { get; private set; }
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Equipment { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Course(int identity, ETypeOfCourse type, DateTime startDate, DateTime endDate, string equipment, List<Lesson> lessons)
        {
            Id = identity;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Equipment = equipment;
            Lessons = lessons;
        }

        public Course()
        {
        }
    }
}