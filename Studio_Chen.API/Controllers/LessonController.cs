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
        public IEnumerable<Lesson> Get()
        {
            return _allLesson.GetList();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allLesson.GetList().Find(x => x.Identity == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Lesson value)
        {
            _allLesson.GetList().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lesson value)
        {
            for (int i = 0; i < _allLesson.GetList().Count; i++)
            {
                if (_allLesson.GetList()[i].Identity == id)
                {
                    _allLesson.GetList()[i].CourseId = value.CourseId;
                    _allLesson.GetList()[i].MeetNumber = value.MeetNumber;
                    _allLesson.GetList()[i].EndHour = value.EndHour;
                    _allLesson.GetList()[i].Date = value.Date;
                    _allLesson.GetList()[i].StartHour = value.StartHour;
                    _allLesson.GetList()[i].Teacher = value.Teacher;
                    _allLesson.GetList()[i].Course = value.Course;
                    _allLesson.GetList()[i].CourseId = value.CourseId;
                    _allLesson.GetList()[i].Teacher = value.Teacher;
                    _allLesson.GetList()[i].TeacherId = value.TeacherId;
                    _allLesson.GetList()[i].Gymnasts = value.Gymnasts;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allLesson.GetList().Count; i++)
            {
                if (_allLesson.GetList()[i].Identity == id)
                    _allLesson.GetList().Remove(_allLesson.GetList()[i]);
            }
        }
    }
}