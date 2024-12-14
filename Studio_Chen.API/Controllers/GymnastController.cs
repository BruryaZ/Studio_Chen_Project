using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastController : ControllerBase
    {
        private readonly IGymnastService _allGymnast;
        public GymnastController(IGymnastService courseService)
        {
            _allGymnast = courseService;
        }
        // GET: api/<GymnastController>
        [HttpGet]
        public IEnumerable<Gymnast> Get()
        {
            return _allGymnast.GetList();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allGymnast.GetList().Find(x => x.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Gymnast value)
        {
            _allGymnast.GetList().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gymnast value)
        {
            for (int i = 0; i < _allGymnast.GetList().Count; i++)
            {
                if (_allGymnast.GetList()[i].Id == id)
                {
                    _allGymnast.GetList()[i].Address = value.Address;
                    _allGymnast.GetList()[i].Phone = value.Phone;
                    _allGymnast.GetList()[i].Identity = value.Identity;
                    _allGymnast.GetList()[i].FirstName = value.FirstName;
                    _allGymnast.GetList()[i].LastName = value.LastName;
                    _allGymnast.GetList()[i].Email = value.Email;
                    _allGymnast.GetList()[i].lessons = value.lessons;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allGymnast.GetList().Count; i++)
            {
                if (_allGymnast.GetList()[i].Id == id)
                    _allGymnast.GetList().Remove(_allGymnast.GetList()[i]);
            }
        }
    }
}