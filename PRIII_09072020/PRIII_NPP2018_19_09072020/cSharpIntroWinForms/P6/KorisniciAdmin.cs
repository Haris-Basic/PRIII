using cSharpIntroWinForms.Ispit_IB170091;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            txtPretraga.Select();
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            try
            {
                cmb_Spol.DataSource = konekcijaNaBazu.Spolovi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(e.ColumnIndex == 5)
            {
                Form frm = new KorisnikSlikePregled_IB170091(korisnik);
                frm.Show();
            }
            
        }

        private void cb_Administrator_CheckedChanged(object sender, EventArgs e)
        {
            var rezultat = new List<Korisnik>();
            foreach (var korisnik in konekcijaNaBazu.Korisnici)
            {
                if (korisnik.Admin == cb_Administrator.Checked)
                {
                    rezultat.Add(korisnik);
                    LoadData(rezultat);
                }
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();
            var rezultat = new List<Korisnik>();

            foreach (var korisnik in konekcijaNaBazu.Korisnici)
            {
                if (korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter))
                {
                    rezultat.Add(korisnik);
                    LoadData(rezultat);
                }
            }
        }

        private void cmb_Spol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rezultat = new List<Korisnik>();
            foreach (var korisnik in konekcijaNaBazu.Korisnici)
            {
                if (korisnik.Spol == cmb_Spol.SelectedItem as Spolovi)
                {
                    rezultat.Add(korisnik);
                    LoadData(rezultat);
                }
            }
        }

        private void btn_Printaj_Click(object sender, EventArgs e)
        {
            var lista = new List<Korisnik>();

            for (int i = 0; i < dgvKorisnici.Rows.Count; i++)
                lista.Add(dgvKorisnici.Rows[i].DataBoundItem as Korisnik);

            Form forma = new frm_Izvjestaj_IB170091(lista);
            forma.ShowDialog();
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(IzracunajSumu);
            t1.Start();
        }
        private void IzracunajSumu()
        {
            Thread.Sleep(2000);
            Action action = () =>
            {
                int Broj = int.Parse(txt_Suma.Text);
                int suma = 0;
                for (int i = 1; i <= Broj; i++)
                {
                    suma += i;
                }
                txt_Suma.Text = suma.ToString();
            };
            BeginInvoke(action);
        }
    }
}
