using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _allLesson;

        public LessonController(ILessonService lessonService)
        {
            _allLesson = lessonService;
        }

        // GET: api/<LessonController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lesson>>> GetAsync()
        {
            var lessons = await _allLesson.GetListAsync();
            return Ok(lessons);
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lesson>> GetAsync(int id)
        {
            var lesson = await _allLesson.GetByIdAsync(id);
            if (lesson == null)
                return NotFound();
            return Ok(lesson);
        }

        // POST api/<LessonController>
        [HttpPost]
        public async Task<ActionResult<Lesson>> PostAsync([FromBody] Lesson value)
        {
            var createdLesson = await _allLesson.AddAsync(value);
            return Ok(createdLesson);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Lesson>> PutAsync(int id, [FromBody] Lesson value)
        {
            var updatedLesson = await _allLesson.UpdateAsync(id, value);
            if (updatedLesson == null)
            {
                return NotFound();
            }
            return Ok(updatedLesson);
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var lesson = await _allLesson.GetByIdAsync(id);
            if (lesson is null)
            {
                return NotFound();
            }
            await _allLesson.DeleteAsync(lesson);
            return NoContent();
        }
    }
}
