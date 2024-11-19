using Microsoft.AspNetCore.Mvc;
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
        public CourseController(ICourseService courseService)
        {
            _allCourses = courseService;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _allCourses.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allCourses.GetAll().Find(x => x.Identity == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            _allCourses.GetAll().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course value)
        {
            for (int i = 0; i < _allCourses.GetAll().Count; i++)
            {
                if (_allCourses.GetAll()[i].Identity == id)
                {
                    _allCourses.GetAll()[i].MeetsNumber = value.MeetsNumber;
                    _allCourses.GetAll()[i].EndDate = value.EndDate;
                    _allCourses.GetAll()[i].StartDate = value.StartDate;
                    _allCourses.GetAll()[i].Type = value.Type;
                    _allCourses.GetAll()[i].Equipment = value.Equipment;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allCourses.GetAll().Count; i++)
            {
                if (_allCourses.GetAll()[i].Identity == id)
                    _allCourses.GetAll().Remove(_allCourses.GetAll()[i]);
            }
        }
    }
}
