using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsistenciaSport.BD.Data;
using AsistenciaSport.BD.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AsistenciaSport.Server.Controllers
{
    [ApiController]
    [Route("api/Cuotas")]
    public class CuotasController : ControllerBase
    {
        private readonly Context context;

        public CuotasController(Context context)
        {
            context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuotas>>> GetCuotas()
        {
            return await context.Cuotas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cuotas>> GetCuotas(int id)
        {
            var cuota = await context.Cuotas.FindAsync(id);

            if (cuota == null)
            {
                return NotFound();
            }

            return cuota;
        }

        [HttpPost]
        public async Task<ActionResult<Cuotas>> PostCuotas(Cuotas cuotas)
        {
            context.Cuotas.Add(cuotas);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCuotas), new { id = cuotas.Id }, cuotas);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuotas(int id, Cuotas cuotas)
        {
            if (id != cuotas.Id)
            {
                return BadRequest();
            }

            context.Entry(cuotas).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuotasExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuotas(int id)
        {
            var cuota = await context.Cuotas.FindAsync(id);
            if (cuota == null)
            {
                return NotFound();
            }

            context.Cuotas.Remove(cuota);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuotasExists(int id)
        {
            return context.Cuotas.Any(e => e.Id == id);
        }
    }
}
