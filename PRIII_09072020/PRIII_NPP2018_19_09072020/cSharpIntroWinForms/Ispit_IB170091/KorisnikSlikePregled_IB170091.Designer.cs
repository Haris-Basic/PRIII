namespace cSharpIntroWinForms.Ispit_IB170091
{
    partial class KorisnikSlikePregled_IB170091
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Lijevo = new System.Windows.Forms.Button();
            this.btn_Desno = new System.Windows.Forms.Button();
            this.pb_Slika = new System.Windows.Forms.PictureBox();
            this.lbl_korisnik = new System.Windows.Forms.Label();
            this.ofd_UcitajSliku = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Lijevo
            // 
            this.btn_Lijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lijevo.Location = new System.Drawing.Point(36, 92);
            this.btn_Lijevo.Name = "btn_Lijevo";
            this.btn_Lijevo.Size = new System.Drawing.Size(91, 152);
            this.btn_Lijevo.TabIndex = 0;
            this.btn_Lijevo.Text = "<";
            this.btn_Lijevo.UseVisualStyleBackColor = true;
            this.btn_Lijevo.Click += new System.EventHandler(this.btn_Lijevo_Click);
            // 
            // btn_Desno
            // 
            this.btn_Desno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desno.Location = new System.Drawing.Point(638, 92);
            this.btn_Desno.Name = "btn_Desno";
            this.btn_Desno.Size = new System.Drawing.Size(91, 152);
            this.btn_Desno.TabIndex = 1;
            this.btn_Desno.Text = ">";
            this.btn_Desno.UseVisualStyleBackColor = true;
            this.btn_Desno.Click += new System.EventHandler(this.btn_Desno_Click);
            // 
            // pb_Slika
            // 
            this.pb_Slika.Location = new System.Drawing.Point(188, 58);
            this.pb_Slika.Name = "pb_Slika";
            this.pb_Slika.Size = new System.Drawing.Size(388, 221);
            this.pb_Slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Slika.TabIndex = 2;
            this.pb_Slika.TabStop = false;
            this.pb_Slika.Click += new System.EventHandler(this.pb_Slika_Click);
            // 
            // lbl_korisnik
            // 
            this.lbl_korisnik.AutoSize = true;
            this.lbl_korisnik.Location = new System.Drawing.Point(33, 9);
            this.lbl_korisnik.Name = "lbl_korisnik";
            this.lbl_korisnik.Size = new System.Drawing.Size(62, 17);
            this.lbl_korisnik.TabIndex = 3;
            this.lbl_korisnik.Text = "Korisnik:";
            // 
            // ofd_UcitajSliku
            // 
            this.ofd_UcitajSliku.FileName = "openFileDialog1";
            // 
            // KorisnikSlikePregled_IB170091
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 346);
            this.Controls.Add(this.lbl_korisnik);
            this.Controls.Add(this.pb_Slika);
            this.Controls.Add(this.btn_Desno);
            this.Controls.Add(this.btn_Lijevo);
            this.Name = "KorisnikSlikePregled_IB170091";
            this.Text = "KorisnikSlikePregled_IB170091";
            this.Load += new System.EventHandler(this.KorisnikSlikePregled_IB170091_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Lijevo;
        private System.Windows.Forms.Button btn_Desno;
        private System.Windows.Forms.PictureBox pb_Slika;
        private System.Windows.Forms.Label lbl_korisnik;
        private System.Windows.Forms.OpenFileDialog ofd_UcitajSliku;
    }
}