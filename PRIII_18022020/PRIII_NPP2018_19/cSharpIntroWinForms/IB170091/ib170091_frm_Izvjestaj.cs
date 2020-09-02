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
using Microsoft.ReportingServices.Diagnostics.Internal;
using cSharpIntroWinForms.P8;

namespace cSharpIntroWinForms.IB170091
{
    public partial class ib170091_frm_Izvjestaj : Form
    {
        private KonekcijaNaBazu _konekcija;
        private Korisnik _korisnik;
        public ib170091_frm_Izvjestaj()
        {
            InitializeComponent();
            _konekcija = DLWMS.DB;
        }

        public ib170091_frm_Izvjestaj(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }

        private void ib170091_frm_Izvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("Ime", _korisnik.Ime));
            rpc.Add(new ReportParameter("Prezime", _korisnik.Prezime));

            List<object> lista = new List<object>();
            int i = 0;
            foreach (var pp in _konekcija.ib170091_KorisniciPredmeti)
            {
                lista.Add(new
                {
                    Rb = i++,
                    Predmet_ = pp.Predmet.Naziv,
                    Ocjena_ = pp.Ocjena,
                    Godina_ = pp.GodinaStudija.Naziv,
                    Datum_ = pp.Datum
                }); 
            }

            var rds = new ReportDataSource();

            rds.Name = "MojDS";
            rds.Value = lista;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
