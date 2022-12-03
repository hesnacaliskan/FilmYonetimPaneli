using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Domain.Entities
{
    public class Salon : BaseEntity
    {        
        public string salonAd { get; set; }
        public ICollection<Film> Films { get; set; }   
    }
}
