using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;



namespace WebAPI_inyeccion_repositorio_EF
{
    public interface IRepositorioEmpleado
    {

        //buscar
        Task<ActionResult<IEnumerable<Empleado>>> Buscar();

        //buscar con id
        Task<ActionResult<Empleado>> BuscarConId(int id);

        //crear
        Task<ActionResult<Empleado>> Crear(Empleado empleado);

        //actualizar 
        Task<IActionResult> Actualizar (int id, Empleado empleado);

        //eliminar 
        Task<IActionResult> Eliminar(int id);

    }
}
