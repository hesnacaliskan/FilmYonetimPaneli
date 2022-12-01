using FilmYonetimPaneli.Application.Abstractions;
using FilmYonetimPaneli.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<FilmYonetimPaneliDbContext>(options => options.UseSqlServer(@"Server=LAPTOP-PBH375GS\SQLEXPRESS;Database=FilmYonetimPaneli;Trusted_Connection=True;TrustServerCertificate=True;"));
            
        }
    }
}
