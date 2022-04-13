using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_inyeccion_repositorio_EF
{
    public class Empleado
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNac { get; set; }
        public int sueldoNeto { get; set; }
    }
}
