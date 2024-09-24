using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsistenciaSport.BD.Data.Entity; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsistenciaSport.BD.Data;

namespace AsistenciaSport.Server.Controllers
{
    [ApiController]
    [Route("api/Miembros")]
    public class MiembroController : Controller
    {
        private readonly Context context;

        public MiembroController(DbContext context)
        {
            context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var miembros = await context.Miembros.Include(m => m.Administrador).ToListAsync();
            return View(miembros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var miembro = await context.Miembros.Include(m => m.Administrador).FirstOrDefaultAsync(m => m.Id == id);
            if (miembro == null)
            {
                return NotFound();
            }
            return View(miembro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                context.Add(miembro);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(miembro);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var miembro = await context.Miembros.FindAsync(id);
            if (miembro == null)
            {
                return NotFound();
            }
            return View(miembro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Miembro miembro)
        {
            if (id != miembro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(miembro);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MiembroExists(miembro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(miembro);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var miembro = await context.Miembros.Include(m => m.Administrador).FirstOrDefaultAsync(m => m.Id == id);
            if (miembro == null)
            {
                return NotFound();
            }
            return View(miembro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var miembro = await context.Miembros.FindAsync(id);
            if (miembro != null)
            {
                context.Miembros.Remove(miembro);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool MiembroExists(int id)
        {
            return context.Miembros.Any(e => e.Id == id);
        }
    }
}
