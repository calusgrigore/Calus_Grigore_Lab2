using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calus_Grigore_Lab2.Models;

namespace Calus_Grigore_Lab2.Data
{
    public class Calus_Grigore_Lab2Context : DbContext
    {
        public Calus_Grigore_Lab2Context (DbContextOptions<Calus_Grigore_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Calus_Grigore_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Calus_Grigore_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
