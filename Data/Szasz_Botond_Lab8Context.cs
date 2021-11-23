using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Szasz_Botond_Lab8.Models;

namespace Szasz_Botond_Lab8.Data
{
    public class Szasz_Botond_Lab8Context : DbContext
    {
        public Szasz_Botond_Lab8Context (DbContextOptions<Szasz_Botond_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Szasz_Botond_Lab8.Models.Book> Book { get; set; }

        public DbSet<Szasz_Botond_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Szasz_Botond_Lab8.Models.Category> Category { get; set; }
    }
}
