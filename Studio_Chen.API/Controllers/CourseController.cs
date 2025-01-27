using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Studio_Chen.API.Models;
using Studio_Chen.Core.DTO_s;
using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _allCourses;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _allCourses = courseService;
            _mapper = mapper;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDTO>>> GetAsync()
        {
            var courses = await _allCourses.GetListAsync();
            var coursesDTO = _mapper.Map<IEnumerable<CourseDTO>>(courses);

            return Ok(coursesDTO);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDTO>> GetAsync(int id)
        {
            var course = await _allCourses.GetByIdAsync(id);
            if (course == null)
                return NotFound();
            return Ok(_mapper.Map<CourseDTO>(course));
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task<ActionResult<CourseDTO>> PostAsync([FromBody] CoursePostModel value)
        {
            var course = _mapper.Map<Course>(value);
            var createdCourse = await _allCourses.AddAsync(course);
            return Ok(_mapper.Map<CourseDTO>(createdCourse));
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CourseDTO>> PutAsync(int id, [FromBody] Course value)
        {
            var updatedCourse = await _allCourses.UpdateAsync(id, _mapper.Map<Course>(value));
            if (updatedCourse == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CourseDTO>(updatedCourse));
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var course = await _allCourses.GetByIdAsync(id);
            if (course is null)
            {
                return NotFound();
            }
            await _allCourses.DeleteAsync(course);
            return NoContent();
        }
    }
}
