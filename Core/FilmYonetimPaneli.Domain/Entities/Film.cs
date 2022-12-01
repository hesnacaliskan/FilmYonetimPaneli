using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Domain.Entities
{
    public class Film : BaseEntity
    {
        public int filmID { get; set; }
        public string filmAd { get; set; }
        public int filmYapimYil { get; set; }
        public ICollection<Salon> Salons { get; set; }

    }
}
