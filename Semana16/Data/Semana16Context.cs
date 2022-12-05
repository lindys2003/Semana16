using Microsoft.EntityFrameworkCore;
using semana16_1.Controllers;
using semana16_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana16.Data
{
    public class semana16Context : DbContext
    {
        public semana16Context(DbContextOptions<semana16Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }

        public static implicit operator semana16Context(semana16_1Context v)
        {
            throw new NotImplementedException();
        }
    }
}
