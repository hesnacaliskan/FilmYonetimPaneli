using FilmYonetimPaneli.Application.Repositories.Movies;
using FilmYonetimPaneli.Domain.Entities;
using FilmYonetimPaneli.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Persistence.Repositories.Movies
{
    public class MovieWriteRepository : WriteRepository<Film>, IMovieWriteRepository
    {
        public MovieWriteRepository(FilmYonetimPaneliDbContext context) : base(context)
        {
        }
    }
}
