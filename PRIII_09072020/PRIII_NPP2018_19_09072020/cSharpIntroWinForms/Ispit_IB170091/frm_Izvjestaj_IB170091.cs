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
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.Ispit_IB170091
{
    public partial class frm_Izvjestaj_IB170091 : Form
    {
        private KonekcijaNaBazu _konekcija;
        private List<Korisnik> _korisnici;
        public frm_Izvjestaj_IB170091()
        {
            InitializeComponent();
            _konekcija = DLWMS.DB;
        }

        public frm_Izvjestaj_IB170091(List<Korisnik> korisnici) : this()
        {
            this._korisnici = korisnici;
        }
        private void frm_Izvjestaj_IB170091_Load(object sender, EventArgs e)
        {

            List<object> lista = new List<object>();
            int i = 0;
            foreach (var kp in _konekcija.KorisniciPredmeti)
            {
                foreach (var korisnik in _korisnici)
                {
                    if(kp.Korisnik.Id == korisnik.Id)
                    {
                        lista.Add(new
                        {
                            Rb = i + 1,
                            Korisnik = korisnik.Ime + " " + korisnik.Prezime,
                            Predmet = kp.Predmet.Naziv,
                            Ocjena = kp.Ocjena,
                            Datum = kp.Datum
                        });
                    }
                }
            }

            var rds = new ReportDataSource();
            rds.Name = "MojDS";
            rds.Value = lista;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
