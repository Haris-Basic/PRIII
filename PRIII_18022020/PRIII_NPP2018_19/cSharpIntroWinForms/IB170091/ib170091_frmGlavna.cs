using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms.IB170091
{
    public partial class ib170091_frmGlavna : Form
    {
        
        public ib170091_frmGlavna()
        {
            InitializeComponent();
        }

        private void btn_GodineStudija_Click(object sender, EventArgs e)
        {
            Form forma = new ib170091_frmGodineStudijaForm();
            forma.ShowDialog();
        }

        private void btn_PolozeniPredmeti_Click(object sender, EventArgs e)
        {
            Form frm = new KorisniciPolozeniPredmeti();
            frm.ShowDialog();
        }

        private void btn_IzracunajSumu_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(IzracunajSumu);
            t1.Start();
        }
        
        private void IzracunajSumu()
        {
            Thread.Sleep(2000);
            Action action = () =>
            {
                int Broj = int.Parse(txt_UneseniBroj.Text);
                int suma = 0;
                for (int i = 1; i <= Broj; i++)
                {
                    suma += i;
                }
                txt_UneseniBroj.Text = suma.ToString();
            };
            BeginInvoke(action);             
        }
    }
}
