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
        public ActionResult Get()
        {
            var courses = _allCourses.GetList();
            return Ok(courses);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allCourses.GetList().Find(x => x.Identity == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            _allCourses.GetList().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course value)
        {
            for (int i = 0; i < _allCourses.GetList().Count; i++)
            {
                if (_allCourses.GetList()[i].Identity == id)
                {
                    _allCourses.GetList()[i].MeetsNumber = value.MeetsNumber;
                    _allCourses.GetList()[i].EndDate = value.EndDate;
                    _allCourses.GetList()[i].StartDate = value.StartDate;
                    _allCourses.GetList()[i].Type = value.Type;
                    _allCourses.GetList()[i].Equipment = value.Equipment;
                    _allCourses.GetList()[i].Lessons = value.Lessons;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allCourses.GetList().Count; i++)
            {
                if (_allCourses.GetList()[i].Identity == id)
                    _allCourses.GetList().Remove(_allCourses.GetList()[i]);
            }
        }
    }
}