using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.Ispit_IB170091
{
    public class KorisniciSlike_IB170091
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public byte[] Slika { get; set; }
    }
}
