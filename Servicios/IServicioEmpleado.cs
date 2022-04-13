using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;


namespace Servicios
{
    interface IServicioEmpleado
    {
        //buscar
        Task<Empleado> Buscar();

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
