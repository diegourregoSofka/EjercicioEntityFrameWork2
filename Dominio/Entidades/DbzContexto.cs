using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class DbzContexto : DbContext
    {
        // Colección DBSet
        public DbSet<Personaje> Personajes { get; set; }

        // Método para pasar lo que recibo a mi clase padre
        public DbzContexto(DbContextOptions<DbzContexto> options) : base(options)
        {
           
        }

    }
}
