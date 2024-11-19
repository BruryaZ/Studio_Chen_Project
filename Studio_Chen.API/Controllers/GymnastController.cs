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
            return _allGymnast.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = _allGymnast.GetAll().Find(x => x.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Gymnast value)
        {
            _allGymnast.GetAll().Add(value);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Gymnast value)
        {
            for (int i = 0; i < _allGymnast.GetAll().Count; i++)
            {
                if (_allGymnast.GetAll()[i].Id == id)
                {
                    _allGymnast.GetAll()[i].Address = value.Address;
                    _allGymnast.GetAll()[i].Phone = value.Phone;
                    _allGymnast.GetAll()[i].Identity = value.Identity;
                    _allGymnast.GetAll()[i].FirstName = value.FirstName;
                    _allGymnast.GetAll()[i].LastName = value.LastName;
                    _allGymnast.GetAll()[i].Email = value.Email;
                }
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < _allGymnast.GetAll().Count; i++)
            {
                if (_allGymnast.GetAll()[i].Id == id)
                    _allGymnast.GetAll().Remove(_allGymnast.GetAll()[i]);
            }
        }
    }
}