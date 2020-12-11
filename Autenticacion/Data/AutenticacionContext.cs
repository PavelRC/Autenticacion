using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autenticacion.Usuarios;

namespace Autenticacion.Data
{
    public class AutenticacionContext : DbContext
    {
        public AutenticacionContext (DbContextOptions<AutenticacionContext> options)
            : base(options)
        {
        }

        public DbSet<Autenticacion.Usuarios.Persona> Persona { get; set; }
    }
}
