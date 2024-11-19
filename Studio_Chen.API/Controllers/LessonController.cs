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
            return _allLesson.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allLesson.GetAll().Find(x => x.Identity == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Lesson value)
        {
            _allLesson.GetAll().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lesson value)
        {
            for (int i = 0; i < _allLesson.GetAll().Count; i++)
            {
                if (_allLesson.GetAll()[i].Identity == id)
                {
                    _allLesson.GetAll()[i].CourseIdentity = value.CourseIdentity;
                    _allLesson.GetAll()[i].MeetNumber = value.MeetNumber;
                    _allLesson.GetAll()[i].EndHour = value.EndHour;
                    _allLesson.GetAll()[i].EquipmentList = value.EquipmentList;
                    _allLesson.GetAll()[i].Date = value.Date;
                    _allLesson.GetAll()[i].StartHour = value.StartHour;
                    _allLesson.GetAll()[i].Teacher = value.Teacher;
                    _allLesson.GetAll()[i].GymnastList = value.GymnastList;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allLesson.GetAll().Count; i++)
            {
                if (_allLesson.GetAll()[i].Identity == id)
                    _allLesson.GetAll().Remove(_allLesson.GetAll()[i]);
            }
        }
    }
}