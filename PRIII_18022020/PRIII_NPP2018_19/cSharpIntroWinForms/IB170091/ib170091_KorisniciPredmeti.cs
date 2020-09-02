using cSharpIntroWinForms.P10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB170091
{
    public class ib170091_KorisniciPredmeti
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Predmeti Predmet { get; set; }
        public virtual ib170091_GodineStudija GodinaStudija { get; set; }
        public int Ocjena { get; set; }
        public string Datum { get; set; }
    }
}
