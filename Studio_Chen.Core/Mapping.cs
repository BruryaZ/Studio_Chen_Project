using Studio_Chen.Core.DTO_s;
using Studio_Chen.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core
{
    public class Mapping
    {
        public CourseDTO MapToCourseDTO(Course course)
        {
            return new CourseDTO
            {
                EndDate = course.EndDate,
                Equipment = course.Equipment,
                Id = course.Id,
                StartDate = course.StartDate,
                Type = course.Type
            };
        }
    }
}