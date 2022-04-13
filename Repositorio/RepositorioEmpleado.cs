using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Repositorio
{
    public class RepositorioEmpleado: IRepositorioEmpleado
    {
        //private WebAPIContext _context;


        /*public RepositorioEmpleado(WebAPIContext context) {
            this._context = context;
        }*/

        public void Actualizar(int idActualizar, Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Empleado>>> Buscar()
        {
            //return await _context.Empleado.ToListAsync();
            throw new NotImplementedException();

        }

        public Task<Empleado> BuscarConId(int id)
        {
            throw new NotImplementedException();
        }

        public void Crear(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
