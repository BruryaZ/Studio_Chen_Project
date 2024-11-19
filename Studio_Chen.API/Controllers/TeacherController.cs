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
            return _allTeachers.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allTeachers.GetAll().Find(x => x.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Teacher value)
        {
            _allTeachers.GetAll().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher value)
        {
            for (int i = 0; i < _allTeachers.GetAll().Count; i++)
            {
                if (_allTeachers.GetAll()[i].Id == id)
                {
                    _allTeachers.GetAll()[i].Identity = value.Identity;
                    _allTeachers.GetAll()[i].Address = value.Address;
                    _allTeachers.GetAll()[i].FirstName = value.FirstName;
                    _allTeachers.GetAll()[i].LastName = value.LastName;
                    _allTeachers.GetAll()[i].Email = value.Email;
                    _allTeachers.GetAll()[i].Phone = value.Phone;
                    _allTeachers.GetAll()[i].courses = value.courses;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allTeachers.GetAll().Count; i++)
            {
                if (_allTeachers.GetAll()[i].Id == id)
                    _allTeachers.GetAll().Remove(_allTeachers.GetAll()[i]);
            }
        }
    }
}