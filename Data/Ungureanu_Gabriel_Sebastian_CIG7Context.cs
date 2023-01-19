using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Gabriel_Sebastian_CIG7.Models;

namespace Ungureanu_Gabriel_Sebastian_CIG7.Data
{
    public class Ungureanu_Gabriel_Sebastian_CIG7Context : DbContext
    {
        public Ungureanu_Gabriel_Sebastian_CIG7Context (DbContextOptions<Ungureanu_Gabriel_Sebastian_CIG7Context> options)
            : base(options)
        {
        }

        public DbSet<Ungureanu_Gabriel_Sebastian_CIG7.Models.Bilet> Bilet { get; set; } = default!;

        public DbSet<Ungureanu_Gabriel_Sebastian_CIG7.Models.Oras> Oras { get; set; }

        public DbSet<Ungureanu_Gabriel_Sebastian_CIG7.Models.Companie> Companie { get; set; }
    }
}
