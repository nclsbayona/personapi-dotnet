using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.entities;

namespace personapi_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesionesApiController : ControllerBase
    {
        private readonly PersonaDbContext _context;

        public ProfesionesApiController(PersonaDbContext context)
        {
            _context = context;
        }

        // GET: api/Profesiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesion>>> GetProfesions()
        {
            return await _context.Profesions.ToListAsync();
        }

        // GET: api/Profesiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesion>> GetProfesion(int id)
        {
            var profesion = await _context.Profesions.FindAsync(id);

            if (profesion == null)
            {
                return NotFound();
            }

            return profesion;
        }

        // PUT: api/Profesiones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesion(int id, Profesion profesion)
        {
            if (id != profesion.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Profesiones
        [HttpPost]
        public async Task<ActionResult<Profesion>> PostProfesion(Profesion profesion)
        {
            _context.Profesions.Add(profesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesion", new { id = profesion.Id }, profesion);
        }

        // DELETE: api/Profesiones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profesion>> DeleteProfesion(int id)
        {
            var profesion = await _context.Profesions.FindAsync(id);
            if (profesion == null)
            {
                return NotFound();
            }

            _context.Profesions.Remove(profesion);
            await _context.SaveChangesAsync();

            return profesion;
        }

        private bool ProfesionExists(int id)
        {
            return _context.Profesions.Any(e => e.Id == id);
        }
    }
}