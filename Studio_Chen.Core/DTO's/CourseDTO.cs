using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.DTO_s
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Equipment { get; set; }
    }
}
