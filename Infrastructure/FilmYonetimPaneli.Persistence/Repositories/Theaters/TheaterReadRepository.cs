using FilmYonetimPaneli.Application.Repositories.Theatres;
using FilmYonetimPaneli.Domain.Entities;
using FilmYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories.Theatres
{
    public class TheaterReadRepository : ReadRepository<Salon>, ITheaterReadRepository
    {
        public TheaterReadRepository(FilmYonetimPaneliDbContext context) : base(context)
        {
        }
    }
}
