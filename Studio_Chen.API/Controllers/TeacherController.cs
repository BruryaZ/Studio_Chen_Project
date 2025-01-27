using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAsync()
        {
            var teachers = await _allTeachers.GetListAsync();
            return Ok(teachers);
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetAsync(int id)
        {
            var teacher = await _allTeachers.GetByIdAsync(id);
            if (teacher == null)
                return NotFound();
            return Ok(teacher);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostAsync([FromBody] Teacher value)
        {
            var createdTeacher = await _allTeachers.AddAsync(value);
            return Ok(createdTeacher);
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Teacher>> PutAsync(int id, [FromBody] Teacher value)
        {
            var updatedTeacher = await _allTeachers.UpdateAsync(id, value);
            if (updatedTeacher == null)
            {
                return NotFound();
            }
            return Ok(updatedTeacher);
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var teacher = await _allTeachers.GetByIdAsync(id);
            if (teacher is null)
            {
                return NotFound();
            }
            await _allTeachers.DeleteAsync(teacher);
            return NoContent();
        }
    }
}
