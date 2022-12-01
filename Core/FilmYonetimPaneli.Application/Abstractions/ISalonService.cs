using FilmYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Abstractions
{
    public interface ISalonService
    {
        List<Salon> GetSalons();
    }
}
