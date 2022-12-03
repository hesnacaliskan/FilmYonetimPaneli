using FilmYonetimPaneli.Application.Repositories.Theatres;
using FilmYonetimPaneli.Domain.Entities;
using FilmYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories.Theaters
{
    public class TheaterWriteRepository : WriteRepository<Salon>, ITheaterWriteRepository
    {
        public TheaterWriteRepository(FilmYonetimPaneliDbContext context) : base(context)
        {
        }
    }
}
