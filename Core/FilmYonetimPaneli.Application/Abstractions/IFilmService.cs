using System;
using FilmYonetimPaneli.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Abstractions
{
    public interface IFilmService
    {
        List<Film> GetFilms();
    }
}
