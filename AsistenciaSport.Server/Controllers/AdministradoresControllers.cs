using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsistenciaSport.BD.Data.Entity; 
using AsistenciaSport.BD.Data;

namespace AsistenciaSport.Server.Controllers
{
    [ApiController]
    [Route("api/Administradores")]
    public class AdministradoresController : ControllerBase
    {
        private readonly Context context;

        public AdministradoresController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrador>>> GetAdministradores()
        {
            return await context.Administradores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Administrador>> GetAdministrador(int id)
        {
            var administrador = await context.Administradores.FindAsync(id);

            if (administrador == null)
            {
                return NotFound();
            }

            return administrador;
        }

        [HttpPost]
        public async Task<ActionResult<Administrador>> PostAdministrador(Administrador administrador)
        {
            context.Administradores.Add(administrador);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAdministrador), new { id = administrador.Id }, administrador);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrador(int id, Administrador administrador)
        {
            if (id != administrador.Id)
            {
                return BadRequest();
            }

            context.Entry(administrador).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorExists(id))
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
        public async Task<IActionResult> DeleteAdministrador(int id)
        {
            var administrador = await context.Administradores.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }

            context.Administradores.Remove(administrador);
            await context.SaveChangesAsync();

            return NoContent();
        }
        private bool AdministradorExists(int id)
        {
            return context.Administradores.Any(e => e.Id == id);
        }
    }
}
