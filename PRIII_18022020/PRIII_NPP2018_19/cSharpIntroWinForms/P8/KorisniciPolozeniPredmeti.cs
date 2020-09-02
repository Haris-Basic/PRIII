using cSharpIntroWinForms.IB170091;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            korisnik = VratiKorisnika(1); // salje se Id korisnika kome zelimo dodat predmete

        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private Korisnik VratiKorisnika(int id)
        {
            foreach (var item in konekcijaNaBazu.Korisnici)
            {
                if (id == item.Id)
                    return item;
            }
            return null;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            LoadData();
            OsvjeziGrid();
        }

        private void LoadData()
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();

            var rezultat = new List<ib170091_GodineStudija>();
            foreach (var item in konekcijaNaBazu.GodineStudija)
            {
                if (item.Aktivna)
                    rezultat.Add(item);
            }
            cmbGodineStudija.DataSource = rezultat;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (korisnik != null &&
                Validator.ObaveznoPolje(txt_Ocjena, err, "Ne smijes zaboravit ocjenu") &&
                Validator.ObaveznoPolje(cmbPredmeti, err, "Neispravan unos") &&
                Validator.ObaveznoPolje(cmbGodineStudija, err, "Neispravan unos") && 
                ValidanOdabir())
            {
                var zapis = new ib170091_KorisniciPredmeti();

                zapis.Korisnik = korisnik;
                zapis.Predmet = cmbPredmeti.SelectedItem as Predmeti;
                zapis.GodinaStudija = cmbGodineStudija.SelectedItem as ib170091_GodineStudija;
                zapis.Ocjena = int.Parse(txt_Ocjena.Text);
                zapis.Datum = dtpDatumPolaganja.Value.ToString();

                konekcijaNaBazu.ib170091_KorisniciPredmeti.Add(zapis);
                konekcijaNaBazu.SaveChanges();

                MessageBox.Show("Dodavanje je uspjesno.");
                OsvjeziGrid();
            }
        }

        private bool ValidanOdabir()
        {
            foreach (var item in konekcijaNaBazu.ib170091_KorisniciPredmeti)
            {
                if ((cmbPredmeti.SelectedItem as Predmeti).Id == item.Predmet.Id &&
                    (cmbGodineStudija.SelectedItem as ib170091_GodineStudija).Id == item.GodinaStudija.Id)
                {
                    MessageBox.Show("Ne mozete dodavati isti predmet za istu godinu 2 puta.");
                    return false;
                }
            }
            if (int.Parse(txt_Ocjena.Text) < 6 && int.Parse(txt_Ocjena.Text) > 10)
            {
                MessageBox.Show("Greska: Ocjena vam nije ispravna.");
                return false;
            }
            return true;
        }

        private void OsvjeziGrid()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.ib170091_KorisniciPredmeti.ToList();
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                Form frm = new ib170091_frm_Izvjestaj(korisnik);
                frm.ShowDialog();
            }
        }
    }
}
