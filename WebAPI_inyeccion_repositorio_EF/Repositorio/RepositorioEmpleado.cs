using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAPI_inyeccion_repositorio_EF.Data;

namespace WebAPI_inyeccion_repositorio_EF
{
    public class RepositorioEmpleado : ControllerBase, IRepositorioEmpleado
    {
        private WebAPIContext _context;


        public RepositorioEmpleado(WebAPIContext context)
        {
            this._context = context;
        }

        
        public async Task<IActionResult> Actualizar(int id, Empleado empleado)
        {
            if (id != empleado.id)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
            //throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Empleado>>> Buscar()
        {
            return await _context.Empleado.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<ActionResult<Empleado>> BuscarConId(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;

            //throw new NotImplementedException();
        }

        public  async Task<ActionResult<Empleado>> Crear(Empleado empleado)
        {
            _context.Empleado.Add(empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = empleado.id }, empleado);
            //throw new NotImplementedException();
        }

        public  async Task<IActionResult> Eliminar(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            _context.Empleado.Remove(empleado);
            await _context.SaveChangesAsync();

            return NoContent();
            //throw new NotImplementedException();
        }




        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.id == id);
        }
    }
}
