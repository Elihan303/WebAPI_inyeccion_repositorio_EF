using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_inyeccion_repositorio_EF;
using WebAPI_inyeccion_repositorio_EF.Data;

namespace WebAPI_inyeccion_repositorio_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly WebAPIContext _context;
        IServicioEmpleado ServicioEmpleado;

        public EmpleadosController(WebAPIContext context, IServicioEmpleado ServicioEmpleado)
        {
            _context = context;
            this.ServicioEmpleado = ServicioEmpleado;

        }

        // GET: api/Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleado()
        {
            return await ServicioEmpleado.Buscar();
        }

        // GET: api/Empleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(int id)
        {
            return await ServicioEmpleado.BuscarConId(id);
        }

        // PUT: api/Empleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(int id, Empleado empleado)
        {
            return await ServicioEmpleado.Actualizar(id, empleado);
        }

        // POST: api/Empleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empleado>> PostEmpleado(Empleado empleado)
        {
            return await ServicioEmpleado.Crear(empleado);
        }

        // DELETE: api/Empleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            return await ServicioEmpleado.Eliminar(id);
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.id == id);
        }
    }
}
