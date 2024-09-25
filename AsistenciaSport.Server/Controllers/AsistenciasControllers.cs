using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsistenciaSport.BD.Data.Entity;
using AsistenciaSport.BD.Data;

namespace AsistenciaSport.Server.Controllers
{
    [ApiController]
    [Route("api/Asistencias")]
    public class AsistenciasController : ControllerBase
    {
        private readonly Context context;

        public AsistenciasController(Context context)
        {
            context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistencias>>> GetAsistencias()
        {
            return await context.Asistencia.Include(a => a.Miembro).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Asistencias>> GetAsistencias(int id)
        {
            var asistencias = await context.Asistencia.Include(a => a.Miembro).MinAsync();

            if (asistencias == null)
            {
                return NotFound();
            }

            return asistencias;
        }

        [HttpPost]
        public async Task<ActionResult<Asistencias>> PostAsistencias(Asistencias asistencias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Asistencia.Add(asistencias);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAsistencias), new { id = asistencias.Id }, asistencias);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencias(int id, Asistencias asistencias)
        {
            if (id != asistencias.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Entry(asistencias).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsistenciasExists(id))
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
        public async Task<IActionResult> DeleteAsistencias(int id)
        {
            var asistencias = await context.Asistencia.FindAsync(id);
            if (asistencias == null)
            {
                return NotFound();
            }

            context.Asistencia.Remove(asistencias);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsistenciasExists(int id)
        {
            return context.Asistencia.Any(e => e.Id == id);
        }
    }
}
