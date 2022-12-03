using FilmYonetimPaneli.Application.Abstractions;
using FilmYonetimPaneli.Application.Repositories.Movies;
using FilmYonetimPaneli.Application.Repositories.Theatres;
using FilmYonetimPaneli.Persistence.Contexts;
using FilmYonetimPaneli.Persistence.Repositories.Movies;
using FilmYonetimPaneli.Persistence.Repositories.Theaters;
using FilmYonetimPaneli.Persistence.Repositories.Theatres;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<FilmYonetimPaneliDbContext>(options => options.UseSqlServer("Server=LAPTOP-PBH375GS\\SQLEXPRESS;Database=FilmYonetimPaneliDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped<IMovieReadRepository, MovieReadRepository>();
            services.AddScoped<IMovieWriteRepository, MovieWriteRepository>();
            services.AddScoped<ITheaterReadRepository, TheaterReadRepository>();
            services.AddScoped<ITheaterWriteRepository, TheaterWriteRepository>();
            
            
        }
    }
}
