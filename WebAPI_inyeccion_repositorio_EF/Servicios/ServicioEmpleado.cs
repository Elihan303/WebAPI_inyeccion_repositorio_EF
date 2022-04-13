using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_inyeccion_repositorio_EF
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        IRepositorioEmpleado RepEmpleado;
        //constructor
        public ServicioEmpleado(IRepositorioEmpleado RepEmpleado) {
            this.RepEmpleado = RepEmpleado;
        }

        public Task<IActionResult> Actualizar(int id, Empleado empleado)
        {
            return RepEmpleado.Actualizar(id, empleado);
            //throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Empleado>>> Buscar()
        {
            return RepEmpleado.Buscar();
            //throw new NotImplementedException();
        }

        public Task<ActionResult<Empleado>> BuscarConId(int id)
        {
            return RepEmpleado.BuscarConId(id);
            //throw new NotImplementedException();
        }

        public Task<ActionResult<Empleado>> Crear(Empleado empleado)
        {
            return RepEmpleado.Crear(empleado);
            //throw new NotImplementedException();
        }

        public Task<IActionResult> Eliminar(int id)
        {
            return RepEmpleado.Eliminar(id);
            //throw new NotImplementedException();
        }
    }
}
