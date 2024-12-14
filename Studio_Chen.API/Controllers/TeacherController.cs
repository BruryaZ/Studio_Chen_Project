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
        public IEnumerable<Teacher> Get()
        {
            return _allTeachers.GetList();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allTeachers.GetList().Find(x => x.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Teacher value)
        {
            _allTeachers.GetList().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher value)
        {
            for (int i = 0; i < _allTeachers.GetList().Count; i++)
            {
                if (_allTeachers.GetList()[i].Id == id)
                {
                    _allTeachers.GetList()[i].Identity = value.Identity;
                    _allTeachers.GetList()[i].Address = value.Address;
                    _allTeachers.GetList()[i].FirstName = value.FirstName;
                    _allTeachers.GetList()[i].LastName = value.LastName;
                    _allTeachers.GetList()[i].Email = value.Email;
                    _allTeachers.GetList()[i].Phone = value.Phone;
                    _allTeachers.GetList()[i].Lessons = value.Lessons;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allTeachers.GetList().Count; i++)
            {
                if (_allTeachers.GetList()[i].Id == id)
                    _allTeachers.GetList().Remove(_allTeachers.GetList()[i]);
            }
        }
    }
}