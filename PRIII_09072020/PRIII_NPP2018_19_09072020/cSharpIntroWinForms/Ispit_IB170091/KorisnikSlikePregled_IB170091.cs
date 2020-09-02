using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Ispit_IB170091
{
    public partial class KorisnikSlikePregled_IB170091 : Form
    {
        private KonekcijaNaBazu _konekcija;
        private Korisnik _korisnik;
        private int _brojac;
        
        public KorisnikSlikePregled_IB170091()
        {
            InitializeComponent();
            _konekcija = DLWMS.DB;
        }
        public KorisnikSlikePregled_IB170091(Korisnik korisnik) : this()
        {
            _korisnik = korisnik;
            _brojac = 0;
          
        }
     
        private void KorisnikSlikePregled_IB170091_Load(object sender, EventArgs e)
        {
            lbl_korisnik.Text = _korisnik.Ime;
            UcitajSlikeKorisnika(_brojac);
        }

        private void UcitajSlikeKorisnika(int pozicija)
        {
            var _slike = new List<byte[]>();
            foreach (var item in _konekcija.KorisniciSlike)
            {
                if (item.Korisnik == _korisnik)
                    _slike.Add(item.Slika);
            }
            if (_slike.Count != 0)
            {
                if (pozicija < _slike.Count)
                    pb_Slika.Image = ImageHelper.FromByteToImage(_slike[pozicija]);
                else
                {
                    _brojac = _slike.Count - 1;
                    pb_Slika.Image = ImageHelper.FromByteToImage(_slike[_slike.Count - 1]);
                    MessageBox.Show("Pokušava se pristupiti slici koja ne postoji.");
                }
            }
            else
                MessageBox.Show("Korisnik još uvijek ne posjeduje niti jednu profilnu sliku.");
        }

        private void btn_Lijevo_Click(object sender, EventArgs e)
        {
            if (_brojac == 0)
                UcitajSlikeKorisnika(_brojac);
            else
                UcitajSlikeKorisnika(--_brojac);
        }
        private void btn_Desno_Click(object sender, EventArgs e)
        {
            UcitajSlikeKorisnika(++_brojac);
        }

        private void pb_Slika_Click(object sender, EventArgs e)
        {
            if (ofd_UcitajSliku.ShowDialog() == DialogResult.OK)
            {
                pb_Slika.Image = Image.FromFile(ofd_UcitajSliku.FileName);

                var temp = new KorisniciSlike_IB170091();
                temp.Korisnik = _korisnik;
                temp.Slika = ImageHelper.FromImageToByte(pb_Slika.Image);
                _konekcija.KorisniciSlike.Add(temp);
                _konekcija.SaveChanges();
            }
        }
    }
}
