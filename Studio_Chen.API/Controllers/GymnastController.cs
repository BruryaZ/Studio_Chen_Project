using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Core.Models;
using Studio_Chen.Core.Services;
using Studio_Chen.Data.Models;
using Studio_Chen.Service.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studio_Chen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastController : ControllerBase
    {
        private readonly IGymnastService _allGymnast;

        public GymnastController(IGymnastService gymnastService)
        {
            _allGymnast = gymnastService;
        }

        // GET: api/<GymnastController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gymnast>>> GetAsync()
        {
            var gymnasts = await _allGymnast.GetListAsync();
            return Ok(gymnasts);
        }

        // GET api/<GymnastController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gymnast>> GetAsync(int id)
        {
            var gymnast = await _allGymnast.GetByIdAsync(id);
            if (gymnast == null)
                return NotFound();
            return Ok(gymnast);
        }

        // POST api/<GymnastController>
        [HttpPost]
        public async Task<ActionResult<Gymnast>> PostAsync([FromBody] Gymnast value)
        {
            var createdGymnast = await _allGymnast.AddAsync(value);
            return Ok(createdGymnast);
        }

        // PUT api/<GymnastController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Gymnast>> PutAsync(int id, [FromBody] Gymnast value)
        {
            var updatedGymnast = await _allGymnast.UpdateAsync(id, value);
            if (updatedGymnast == null)
            {
                return NotFound();
            }
            return Ok(updatedGymnast);
        }

        // DELETE api/<GymnastController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var gymnast = await _allGymnast.GetByIdAsync(id);
            if (gymnast is null)
            {
                return NotFound();
            }
            await _allGymnast.DeleteAsync(gymnast);
            return NoContent();
        }
    }
}
