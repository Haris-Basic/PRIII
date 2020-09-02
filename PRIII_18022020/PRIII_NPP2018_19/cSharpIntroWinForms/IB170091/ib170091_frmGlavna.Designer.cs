namespace cSharpIntroWinForms.IB170091
{
    partial class ib170091_frmGlavna
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
            this.components = new System.ComponentModel.Container();
            this.btn_GodineStudija = new System.Windows.Forms.Button();
            this.btn_PolozeniPredmeti = new System.Windows.Forms.Button();
            this.btn_IzracunajSumu = new System.Windows.Forms.Button();
            this.txt_UneseniBroj = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GodineStudija
            // 
            this.btn_GodineStudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GodineStudija.Location = new System.Drawing.Point(34, 34);
            this.btn_GodineStudija.Name = "btn_GodineStudija";
            this.btn_GodineStudija.Size = new System.Drawing.Size(166, 151);
            this.btn_GodineStudija.TabIndex = 0;
            this.btn_GodineStudija.Text = "Godine studija";
            this.btn_GodineStudija.UseVisualStyleBackColor = true;
            this.btn_GodineStudija.Click += new System.EventHandler(this.btn_GodineStudija_Click);
            // 
            // btn_PolozeniPredmeti
            // 
            this.btn_PolozeniPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PolozeniPredmeti.Location = new System.Drawing.Point(256, 34);
            this.btn_PolozeniPredmeti.Name = "btn_PolozeniPredmeti";
            this.btn_PolozeniPredmeti.Size = new System.Drawing.Size(166, 151);
            this.btn_PolozeniPredmeti.TabIndex = 1;
            this.btn_PolozeniPredmeti.Text = "Polozeni predmeti";
            this.btn_PolozeniPredmeti.UseVisualStyleBackColor = true;
            this.btn_PolozeniPredmeti.Click += new System.EventHandler(this.btn_PolozeniPredmeti_Click);
            // 
            // btn_IzracunajSumu
            // 
            this.btn_IzracunajSumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IzracunajSumu.Location = new System.Drawing.Point(488, 109);
            this.btn_IzracunajSumu.Name = "btn_IzracunajSumu";
            this.btn_IzracunajSumu.Size = new System.Drawing.Size(173, 76);
            this.btn_IzracunajSumu.TabIndex = 2;
            this.btn_IzracunajSumu.Text = "Izracunaj sumu";
            this.btn_IzracunajSumu.UseVisualStyleBackColor = true;
            this.btn_IzracunajSumu.Click += new System.EventHandler(this.btn_IzracunajSumu_Click);
            // 
            // txt_UneseniBroj
            // 
            this.txt_UneseniBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UneseniBroj.Location = new System.Drawing.Point(488, 34);
            this.txt_UneseniBroj.Name = "txt_UneseniBroj";
            this.txt_UneseniBroj.Size = new System.Drawing.Size(173, 30);
            this.txt_UneseniBroj.TabIndex = 3;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ib170091_frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 226);
            this.Controls.Add(this.txt_UneseniBroj);
            this.Controls.Add(this.btn_IzracunajSumu);
            this.Controls.Add(this.btn_PolozeniPredmeti);
            this.Controls.Add(this.btn_GodineStudija);
            this.Name = "ib170091_frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ib170091_frmGlavna";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GodineStudija;
        private System.Windows.Forms.Button btn_PolozeniPredmeti;
        private System.Windows.Forms.Button btn_IzracunajSumu;
        private System.Windows.Forms.TextBox txt_UneseniBroj;
        private System.Windows.Forms.ErrorProvider err;
    }
}