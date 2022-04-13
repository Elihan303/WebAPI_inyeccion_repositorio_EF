using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_inyeccion_repositorio_EF;

namespace WebAPI_inyeccion_repositorio_EF.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_inyeccion_repositorio_EF.Empleado> Empleado { get; set; }
    }
}
