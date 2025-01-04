using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Studio_Chen.API.Models;
using Studio_Chen.Core.DTO_s;
using Studio_Chen.Core.Models;
using Studio_Chen.Data.Models;
using Studio_Chen.Service;
using Studio_Chen.Service.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        //GET: api/<CourseController>
        [HttpGet]
        public ActionResult Get()
        {
            var courses = _allCourses.GetList();
            var coursesDTO = _mapper.Map<IEnumerable<CourseDTO>>(courses);

            return Ok(coursesDTO);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allCourses.GetById(id);
            if (course == null)
                return NotFound();
            return Ok(_mapper.Map<CourseDTO>(course));
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] CoursePostModel value)
        {
            var course = _mapper.Map<Course>(value);
            return Ok(_allCourses.Add(course));
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course value)
        {
            var course = _allCourses.Update(id, _mapper.Map<Course>(value));
            return Ok(course);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var course = _allCourses.GetById(id);
            if (course is null)
            {
                return NotFound();
            }
            _allCourses.Delete(course);
            return NoContent();
        }
    }
}