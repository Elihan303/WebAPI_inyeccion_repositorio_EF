using System;
using System.Collections.Generic;
using Repositorio;
using Microsoft.AspNetCore;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        IRepositorioEmpleado RepEmpleado;
        //constructor
        public ServicioEmpleado(IRepositorioEmpleado RepEmpleado) {
            this.RepEmpleado = RepEmpleado;
        }

        public void Actualizar(int idActualizar, Empleado cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Buscar()
        {
            //return RepEmpleado.Buscar();
            throw new NotImplementedException();
        }

        public Task<Empleado> BuscarConId(int id)
        {
            throw new NotImplementedException();
        }

        public void Crear(Empleado cliente)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
