using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Models;
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
        public ActionResult<Lesson> Get()
        {
            return Ok(_allGymnast.GetList());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var gymnast = _allGymnast.GetById(id);
            if (gymnast == null)
                return NotFound();
            return Ok(gymnast);
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] Gymnast value)
        {
            return Ok(_allGymnast.Add(value));
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Gymnast value)
        {
            return Ok(_allGymnast.Update(id, value));
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var gymnast = _allGymnast.GetById(id);
            if (gymnast is null)
            {
                return NotFound();
            }
            _allGymnast.Delete(gymnast);
            return NoContent();
        }
    }
}