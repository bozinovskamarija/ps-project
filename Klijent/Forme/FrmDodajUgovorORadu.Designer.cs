namespace Klijent
{
	partial class FrmDodajUgovorORadu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajUgovorORadu));
			this.lblKvalifikacije = new System.Windows.Forms.Label();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.lblUlica = new System.Windows.Forms.Label();
			this.lblImeRadnika = new System.Windows.Forms.Label();
			this.lblJMBG = new System.Windows.Forms.Label();
			this.lblPrezimeRadnika = new System.Windows.Forms.Label();
			this.cmbRadnik = new System.Windows.Forms.ComboBox();
			this.cmbRadnoMesto = new System.Windows.Forms.ComboBox();
			this.dtpSklapanje = new System.Windows.Forms.DateTimePicker();
			this.dtpUkidanja = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTip = new System.Windows.Forms.TextBox();
			this.txtNapomena = new System.Windows.Forms.TextBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			this.txtOJ = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblKvalifikacije
			// 
			this.lblKvalifikacije.AutoSize = true;
			this.lblKvalifikacije.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblKvalifikacije.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblKvalifikacije.Location = new System.Drawing.Point(23, 263);
			this.lblKvalifikacije.Name = "lblKvalifikacije";
			this.lblKvalifikacije.Size = new System.Drawing.Size(122, 23);
			this.lblKvalifikacije.TabIndex = 61;
			this.lblKvalifikacije.Text = "Radno mesto:";
			// 
			// btnDodaj
			// 
			this.btnDodaj.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDodaj.Location = new System.Drawing.Point(119, 353);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(337, 46);
			this.btnDodaj.TabIndex = 58;
			this.btnDodaj.Text = "Dodaj ugovor";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// lblUlica
			// 
			this.lblUlica.AutoSize = true;
			this.lblUlica.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblUlica.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUlica.Location = new System.Drawing.Point(23, 220);
			this.lblUlica.Name = "lblUlica";
			this.lblUlica.Size = new System.Drawing.Size(70, 23);
			this.lblUlica.TabIndex = 60;
			this.lblUlica.Text = "Radnik:";
			// 
			// lblImeRadnika
			// 
			this.lblImeRadnika.AutoSize = true;
			this.lblImeRadnika.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblImeRadnika.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblImeRadnika.Location = new System.Drawing.Point(23, 32);
			this.lblImeRadnika.Name = "lblImeRadnika";
			this.lblImeRadnika.Size = new System.Drawing.Size(149, 23);
			this.lblImeRadnika.TabIndex = 54;
			this.lblImeRadnika.Text = "Datum sklapanja:";
			// 
			// lblJMBG
			// 
			this.lblJMBG.AutoSize = true;
			this.lblJMBG.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblJMBG.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblJMBG.Location = new System.Drawing.Point(23, 119);
			this.lblJMBG.Name = "lblJMBG";
			this.lblJMBG.Size = new System.Drawing.Size(41, 23);
			this.lblJMBG.TabIndex = 59;
			this.lblJMBG.Text = "Tip:";
			// 
			// lblPrezimeRadnika
			// 
			this.lblPrezimeRadnika.AutoSize = true;
			this.lblPrezimeRadnika.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblPrezimeRadnika.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPrezimeRadnika.Location = new System.Drawing.Point(23, 74);
			this.lblPrezimeRadnika.Name = "lblPrezimeRadnika";
			this.lblPrezimeRadnika.Size = new System.Drawing.Size(141, 23);
			this.lblPrezimeRadnika.TabIndex = 57;
			this.lblPrezimeRadnika.Text = "Datum ukidanja:";
			// 
			// cmbRadnik
			// 
			this.cmbRadnik.Font = new System.Drawing.Font("Candara", 12F);
			this.cmbRadnik.FormattingEnabled = true;
			this.cmbRadnik.Location = new System.Drawing.Point(227, 220);
			this.cmbRadnik.Name = "cmbRadnik";
			this.cmbRadnik.Size = new System.Drawing.Size(296, 27);
			this.cmbRadnik.TabIndex = 70;
			// 
			// cmbRadnoMesto
			// 
			this.cmbRadnoMesto.Font = new System.Drawing.Font("Candara", 12F);
			this.cmbRadnoMesto.FormattingEnabled = true;
			this.cmbRadnoMesto.Location = new System.Drawing.Point(227, 259);
			this.cmbRadnoMesto.Name = "cmbRadnoMesto";
			this.cmbRadnoMesto.Size = new System.Drawing.Size(296, 27);
			this.cmbRadnoMesto.TabIndex = 71;
			this.cmbRadnoMesto.SelectionChangeCommitted += new System.EventHandler(this.cmbRadnoMesto_SelectionChangeCommitted);
			// 
			// dtpSklapanje
			// 
			this.dtpSklapanje.Font = new System.Drawing.Font("Candara", 12F);
			this.dtpSklapanje.Location = new System.Drawing.Point(227, 32);
			this.dtpSklapanje.Name = "dtpSklapanje";
			this.dtpSklapanje.Size = new System.Drawing.Size(267, 27);
			this.dtpSklapanje.TabIndex = 73;
			// 
			// dtpUkidanja
			// 
			this.dtpUkidanja.Font = new System.Drawing.Font("Candara", 12F);
			this.dtpUkidanja.Location = new System.Drawing.Point(227, 74);
			this.dtpUkidanja.Name = "dtpUkidanja";
			this.dtpUkidanja.Size = new System.Drawing.Size(267, 27);
			this.dtpUkidanja.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(23, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 23);
			this.label1.TabIndex = 69;
			this.label1.Text = "Organizaciona jedinica:";
			// 
			// txtTip
			// 
			this.txtTip.Font = new System.Drawing.Font("Candara", 12F);
			this.txtTip.Location = new System.Drawing.Point(227, 115);
			this.txtTip.Name = "txtTip";
			this.txtTip.Size = new System.Drawing.Size(296, 27);
			this.txtTip.TabIndex = 75;
			// 
			// txtNapomena
			// 
			this.txtNapomena.Font = new System.Drawing.Font("Candara", 12F);
			this.txtNapomena.Location = new System.Drawing.Point(227, 151);
			this.txtNapomena.Multiline = true;
			this.txtNapomena.Name = "txtNapomena";
			this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNapomena.Size = new System.Drawing.Size(296, 53);
			this.txtNapomena.TabIndex = 77;
			// 
			// lblNapomena
			// 
			this.lblNapomena.AutoSize = true;
			this.lblNapomena.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblNapomena.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNapomena.Location = new System.Drawing.Point(23, 159);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(104, 23);
			this.lblNapomena.TabIndex = 76;
			this.lblNapomena.Text = "Napomena:";
			// 
			// txtOJ
			// 
			this.txtOJ.Enabled = false;
			this.txtOJ.Font = new System.Drawing.Font("Candara", 12F);
			this.txtOJ.Location = new System.Drawing.Point(227, 302);
			this.txtOJ.Name = "txtOJ";
			this.txtOJ.Size = new System.Drawing.Size(296, 27);
			this.txtOJ.TabIndex = 78;
			// 
			// FrmDodajUgovorORadu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(553, 423);
			this.Controls.Add(this.txtOJ);
			this.Controls.Add(this.txtNapomena);
			this.Controls.Add(this.lblNapomena);
			this.Controls.Add(this.txtTip);
			this.Controls.Add(this.dtpUkidanja);
			this.Controls.Add(this.dtpSklapanje);
			this.Controls.Add(this.cmbRadnoMesto);
			this.Controls.Add(this.cmbRadnik);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblKvalifikacije);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.lblUlica);
			this.Controls.Add(this.lblImeRadnika);
			this.Controls.Add(this.lblJMBG);
			this.Controls.Add(this.lblPrezimeRadnika);
			this.ForeColor = System.Drawing.Color.PowderBlue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDodajUgovorORadu";
			this.Text = "[Preduzece \"MNDJ\"] - Unos ugovora o radu";
			this.Load += new System.EventHandler(this.FrmDodajUgovorORadu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblKvalifikacije;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.Label lblUlica;
		private System.Windows.Forms.Label lblImeRadnika;
		private System.Windows.Forms.Label lblJMBG;
		private System.Windows.Forms.Label lblPrezimeRadnika;
		private System.Windows.Forms.ComboBox cmbRadnik;
		private System.Windows.Forms.ComboBox cmbRadnoMesto;
		private System.Windows.Forms.DateTimePicker dtpSklapanje;
		private System.Windows.Forms.DateTimePicker dtpUkidanja;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTip;
		private System.Windows.Forms.TextBox txtNapomena;
		private System.Windows.Forms.Label lblNapomena;
		private System.Windows.Forms.TextBox txtOJ;
	}
}