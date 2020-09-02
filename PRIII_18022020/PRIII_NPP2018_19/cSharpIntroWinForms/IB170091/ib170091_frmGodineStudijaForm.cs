using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB170091
{
    public partial class ib170091_frmGodineStudijaForm : Form
    {
        private KonekcijaNaBazu _konekcija;
        private bool Edit;
        private ib170091_GodineStudija godina;
        public ib170091_frmGodineStudijaForm()
        {
            InitializeComponent();
            _konekcija = DLWMS.DB;
            Edit = false;
        }
        private void ib170091_frmGodineStudijaForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validator.ObaveznoPolje(txt_Naziv, err, "Naziv godine obavezan"))
            {
                if (!Edit)
                {
                    godina = new ib170091_GodineStudija();
                    godina.Naziv = txt_Naziv.Text;
                    godina.Aktivna = cb_Aktivna.Checked;

                    if (ProvjeriNazivGodine(txt_Naziv.Text))
                    {
                        _konekcija.GodineStudija.Add(godina);
                        MessageBox.Show("Dodavanje uspjesno");
                    }
                }
                else
                {
                    godina.Naziv = txt_Naziv.Text;
                    godina.Aktivna = cb_Aktivna.Checked;

                    _konekcija.Entry(godina).State = EntityState.Modified;
                    MessageBox.Show("Editovanje uspjesno");
                    Edit = false;
                }
                _konekcija.SaveChanges();
                RefreshGrid();
            }
        }

        private bool ProvjeriNazivGodine(string text)
        {
            foreach (var godina in _konekcija.GodineStudija)
            {
                if (string.Compare(text, godina.Naziv) == 0)
                {
                    MessageBox.Show($"Godina sa nazivom {godina.Naziv} vec postoji.");
                    txt_Naziv.Clear();
                    return false;
                }
            }
            return true;
        }

        private void RefreshGrid()
        {
            dgv_GodineStudija.DataSource = null;
            dgv_GodineStudija.DataSource = _konekcija.GodineStudija.ToList();
        }

        private void dgv_GodineStudija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            godina = dgv_GodineStudija.SelectedRows[0].DataBoundItem as ib170091_GodineStudija;

            txt_Naziv.Text = godina.Naziv;
            cb_Aktivna.Checked = godina.Aktivna;

            Edit = true;
        }
    }
}
