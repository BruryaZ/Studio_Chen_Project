using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _allTeachers;
        public TeacherController(ITeacherService teacherService)
        {
            _allTeachers = teacherService;
        }
        // GET: api/<TeacherController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_allTeachers.GetList());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allTeachers.GetById(id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] Teacher value)
        {
            return Ok(_allTeachers.Add(value));
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher value)
        {
            return Ok(_allTeachers.Update(id, value));
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var teacher = _allTeachers.GetById(id);
            if (teacher is null)
            {
                return NotFound();
            }
            _allTeachers.Delete(teacher);
            return NoContent();
        }
    }
}