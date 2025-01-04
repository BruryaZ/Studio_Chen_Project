using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;

namespace Studio_Chen.API.Models
{
    public class CoursePostModel
    {
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Equipment { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
