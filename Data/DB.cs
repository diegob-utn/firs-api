using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Modelos;

namespace firs_api
{
    public class DB : DbContext
    {
        public DB (DbContextOptions<DB> options)
            : base(options)
        {
        }

        public DbSet<api.Modelos.Pelicula> Peliculas { get; set; } = default!;
    }
}
