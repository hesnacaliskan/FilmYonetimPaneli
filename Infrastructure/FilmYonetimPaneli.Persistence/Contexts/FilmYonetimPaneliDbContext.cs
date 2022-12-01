using FilmYonetimPaneli.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Contexts
{
    public class FilmYonetimPaneliDbContext : DbContext
    {
        public FilmYonetimPaneliDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Film> Films { get; set; }
        public DbSet<Salon> Salons { get; set; }
    }
}
