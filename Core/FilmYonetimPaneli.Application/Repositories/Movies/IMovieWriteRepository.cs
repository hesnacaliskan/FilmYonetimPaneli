using FilmYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Repositories.Movies
{
    public interface IMovieWriteRepository : IWriteRepository<Film>
    {
    }
}
