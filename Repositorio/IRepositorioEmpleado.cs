using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using static Repositorio.Empleado;

namespace Repositorio
{
    public interface IRepositorioEmpleado
    {

        //buscar
        Task<ActionResult<IEnumerable<Empleado>>> Buscar();

        //buscar con id
        Task<Empleado> BuscarConId(int id);

        //crear
        void Crear(Empleado empleado);

        //actualizar 
        void Actualizar(int idActualizar, Empleado empleado);

        //eliminar 
        void Eliminar(int id);

    }
}
