using System.ComponentModel.DataAnnotations;

namespace Studio_Chen.Data.Models
{
    public enum ETypeOfCourse { pilates, design_and_toning, Aerobics_band_dynamic_design, floor_exercise, ballet, dance }
    public class Course
    {
        static int count = 1;
        [Key]
        public int Identity { get; private set; }
        public int MeetsNumber { get; set; }
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Equipment { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Course(int identity, int meetsNumber, ETypeOfCourse type, DateTime startDate, DateTime endDate, string equipment, List<Lesson> lessons)
        {
            Identity = identity;
            MeetsNumber = meetsNumber;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Equipment = equipment;
            Lessons = lessons;
        }

        public Course()
        {
            Identity = count++;
        }
    }
}