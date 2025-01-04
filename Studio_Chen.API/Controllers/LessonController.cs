using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Repositories;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _allLesson;
        public LessonController(ILessonService courseService)
        {
            _allLesson = courseService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_allLesson.GetList());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var lesson = _allLesson.GetById(id);
            if (lesson == null)
                return NotFound();
            return Ok(lesson);
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] Lesson value)
        {
            return Ok(_allLesson.Add(value));
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Lesson value)
        {
            return Ok(_allLesson.Update(id, value));
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var lesson = _allLesson.GetById(id);
            if (lesson is null)
            {
                return NotFound();
            }
            _allLesson.Delete(lesson);
            return NoContent();
        }
    }
}