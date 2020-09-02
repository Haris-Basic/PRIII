namespace cSharpIntroWinForms.IB170091
{
    partial class ib170091_frmGodineStudijaForm
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
            this.txt_Naziv = new System.Windows.Forms.TextBox();
            this.cb_Aktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgv_GodineStudija = new System.Windows.Forms.DataGridView();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GodineStudija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Naziv
            // 
            this.txt_Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Naziv.Location = new System.Drawing.Point(29, 26);
            this.txt_Naziv.Name = "txt_Naziv";
            this.txt_Naziv.Size = new System.Drawing.Size(337, 30);
            this.txt_Naziv.TabIndex = 0;
            // 
            // cb_Aktivna
            // 
            this.cb_Aktivna.AutoSize = true;
            this.cb_Aktivna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Aktivna.Location = new System.Drawing.Point(410, 26);
            this.cb_Aktivna.Name = "cb_Aktivna";
            this.cb_Aktivna.Size = new System.Drawing.Size(99, 29);
            this.cb_Aktivna.TabIndex = 1;
            this.cb_Aktivna.Text = "Aktivna";
            this.cb_Aktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(537, 25);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(123, 30);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgv_GodineStudija
            // 
            this.dgv_GodineStudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GodineStudija.Location = new System.Drawing.Point(29, 74);
            this.dgv_GodineStudija.Name = "dgv_GodineStudija";
            this.dgv_GodineStudija.ReadOnly = true;
            this.dgv_GodineStudija.RowHeadersWidth = 51;
            this.dgv_GodineStudija.RowTemplate.Height = 24;
            this.dgv_GodineStudija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GodineStudija.Size = new System.Drawing.Size(631, 169);
            this.dgv_GodineStudija.TabIndex = 3;
            this.dgv_GodineStudija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GodineStudija_CellContentClick);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ib170091_frmGodineStudijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 259);
            this.Controls.Add(this.dgv_GodineStudija);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cb_Aktivna);
            this.Controls.Add(this.txt_Naziv);
            this.Name = "ib170091_frmGodineStudijaForm";
            this.Text = "ib170091_frmGodineStudijaForm";
            this.Load += new System.EventHandler(this.ib170091_frmGodineStudijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GodineStudija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Naziv;
        private System.Windows.Forms.CheckBox cb_Aktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgv_GodineStudija;
        private System.Windows.Forms.ErrorProvider err;
    }
}