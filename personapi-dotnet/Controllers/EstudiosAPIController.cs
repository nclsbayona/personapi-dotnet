using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.entities;

namespace personapi_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiosApiController : ControllerBase
    {
        private readonly PersonaDbContext _context;

        public EstudiosApiController(PersonaDbContext context)
        {
            _context = context;
        }

        // GET: api/Estudios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudio>>> GetEstudios()
        {
            return await _context.Estudios.Include(e => e.IdProfNavigation).ToListAsync();
        }

        // GET: api/Estudios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudio>> GetEstudio(int id)
        {
            var estudio = await _context.Estudios.FindAsync(id);

            if (estudio == null)
            {
                return NotFound();
            }

            return estudio;
        }

        // PUT: api/Estudios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEstudio(int id, Estudio estudio)
        {
            if (id != estudio.IdProf)
            {
                return BadRequest();
            }

            _context.Entry(estudio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudioExists(id))
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

        // POST: api/Estudios
        [HttpPost]
        public async Task<ActionResult<Estudio>> CreateEstudio(Estudio estudio)
        {
            _context.Estudios.Add(estudio);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEstudio), new { id = estudio.IdProf }, estudio);
        }

        // DELETE: api/Estudios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudio(int id)
        {
            var estudio = await _context.Estudios.FindAsync(id);
            if (estudio == null)
            {
                return NotFound();
            }

            _context.Estudios.Remove(estudio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudioExists(int id)
        {
            return _context.Estudios.Any(e => e.IdProf == id);
        }
    }
}