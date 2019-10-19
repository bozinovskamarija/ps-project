namespace Klijent
{
	partial class FrmDetaljiRadnika
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetaljiRadnika));
			this.gbPodaciRadnika = new System.Windows.Forms.GroupBox();
			this.cbMuski = new System.Windows.Forms.CheckBox();
			this.cbZenski = new System.Windows.Forms.CheckBox();
			this.btnObrisiRadnika = new System.Windows.Forms.Button();
			this.lblPol = new System.Windows.Forms.Label();
			this.cmbMesto = new System.Windows.Forms.ComboBox();
			this.cmbKvalifikacije = new System.Windows.Forms.ComboBox();
			this.txtUlica = new System.Windows.Forms.TextBox();
			this.txtJMBG = new System.Windows.Forms.TextBox();
			this.txtPrezimeRadnika = new System.Windows.Forms.TextBox();
			this.txtImeRadnika = new System.Windows.Forms.TextBox();
			this.lblKvalifikacije = new System.Windows.Forms.Label();
			this.lblMesto = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.lblUlica = new System.Windows.Forms.Label();
			this.lblImeRadnika = new System.Windows.Forms.Label();
			this.lblJMBG = new System.Windows.Forms.Label();
			this.lblPrezimeRadnika = new System.Windows.Forms.Label();
			this.gbPodaciRadnika.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPodaciRadnika
			// 
			this.gbPodaciRadnika.Controls.Add(this.cbMuski);
			this.gbPodaciRadnika.Controls.Add(this.cbZenski);
			this.gbPodaciRadnika.Controls.Add(this.btnObrisiRadnika);
			this.gbPodaciRadnika.Controls.Add(this.lblPol);
			this.gbPodaciRadnika.Controls.Add(this.cmbMesto);
			this.gbPodaciRadnika.Controls.Add(this.cmbKvalifikacije);
			this.gbPodaciRadnika.Controls.Add(this.txtUlica);
			this.gbPodaciRadnika.Controls.Add(this.txtJMBG);
			this.gbPodaciRadnika.Controls.Add(this.txtPrezimeRadnika);
			this.gbPodaciRadnika.Controls.Add(this.txtImeRadnika);
			this.gbPodaciRadnika.Controls.Add(this.lblKvalifikacije);
			this.gbPodaciRadnika.Controls.Add(this.lblMesto);
			this.gbPodaciRadnika.Controls.Add(this.btnIzmeni);
			this.gbPodaciRadnika.Controls.Add(this.lblUlica);
			this.gbPodaciRadnika.Controls.Add(this.lblImeRadnika);
			this.gbPodaciRadnika.Controls.Add(this.lblJMBG);
			this.gbPodaciRadnika.Controls.Add(this.lblPrezimeRadnika);
			this.gbPodaciRadnika.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
			this.gbPodaciRadnika.ForeColor = System.Drawing.Color.Black;
			this.gbPodaciRadnika.Location = new System.Drawing.Point(13, 13);
			this.gbPodaciRadnika.Name = "gbPodaciRadnika";
			this.gbPodaciRadnika.Size = new System.Drawing.Size(592, 450);
			this.gbPodaciRadnika.TabIndex = 0;
			this.gbPodaciRadnika.TabStop = false;
			this.gbPodaciRadnika.Text = "Podaci o radniku";
			// 
			// cbMuski
			// 
			this.cbMuski.AutoSize = true;
			this.cbMuski.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
			this.cbMuski.ForeColor = System.Drawing.Color.RoyalBlue;
			this.cbMuski.Location = new System.Drawing.Point(330, 329);
			this.cbMuski.Name = "cbMuski";
			this.cbMuski.Size = new System.Drawing.Size(87, 31);
			this.cbMuski.TabIndex = 93;
			this.cbMuski.Text = "Muški";
			this.cbMuski.UseVisualStyleBackColor = true;
			// 
			// cbZenski
			// 
			this.cbZenski.AutoSize = true;
			this.cbZenski.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
			this.cbZenski.ForeColor = System.Drawing.Color.MediumOrchid;
			this.cbZenski.Location = new System.Drawing.Point(214, 329);
			this.cbZenski.Name = "cbZenski";
			this.cbZenski.Size = new System.Drawing.Size(90, 31);
			this.cbZenski.TabIndex = 92;
			this.cbZenski.Text = "Ženski";
			this.cbZenski.UseVisualStyleBackColor = true;
			// 
			// btnObrisiRadnika
			// 
			this.btnObrisiRadnika.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnObrisiRadnika.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnObrisiRadnika.Location = new System.Drawing.Point(314, 378);
			this.btnObrisiRadnika.Name = "btnObrisiRadnika";
			this.btnObrisiRadnika.Size = new System.Drawing.Size(261, 46);
			this.btnObrisiRadnika.TabIndex = 91;
			this.btnObrisiRadnika.Text = "Obriši radnika";
			this.btnObrisiRadnika.UseVisualStyleBackColor = true;
			this.btnObrisiRadnika.Click += new System.EventHandler(this.btnObrisiRadnika_Click);
			// 
			// lblPol
			// 
			this.lblPol.AutoSize = true;
			this.lblPol.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblPol.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPol.Location = new System.Drawing.Point(16, 329);
			this.lblPol.Name = "lblPol";
			this.lblPol.Size = new System.Drawing.Size(42, 23);
			this.lblPol.TabIndex = 88;
			this.lblPol.Text = "Pol:";
			// 
			// cmbMesto
			// 
			this.cmbMesto.Font = new System.Drawing.Font("Candara", 12F);
			this.cmbMesto.FormattingEnabled = true;
			this.cmbMesto.Location = new System.Drawing.Point(214, 281);
			this.cmbMesto.Name = "cmbMesto";
			this.cmbMesto.Size = new System.Drawing.Size(296, 27);
			this.cmbMesto.TabIndex = 86;
			// 
			// cmbKvalifikacije
			// 
			this.cmbKvalifikacije.Font = new System.Drawing.Font("Candara", 12F);
			this.cmbKvalifikacije.FormattingEnabled = true;
			this.cmbKvalifikacije.Location = new System.Drawing.Point(214, 235);
			this.cmbKvalifikacije.Name = "cmbKvalifikacije";
			this.cmbKvalifikacije.Size = new System.Drawing.Size(296, 27);
			this.cmbKvalifikacije.TabIndex = 85;
			// 
			// txtUlica
			// 
			this.txtUlica.Font = new System.Drawing.Font("Candara", 12F);
			this.txtUlica.Location = new System.Drawing.Point(214, 192);
			this.txtUlica.Name = "txtUlica";
			this.txtUlica.Size = new System.Drawing.Size(296, 27);
			this.txtUlica.TabIndex = 84;
			// 
			// txtJMBG
			// 
			this.txtJMBG.Font = new System.Drawing.Font("Candara", 12F);
			this.txtJMBG.Location = new System.Drawing.Point(214, 147);
			this.txtJMBG.Name = "txtJMBG";
			this.txtJMBG.Size = new System.Drawing.Size(296, 27);
			this.txtJMBG.TabIndex = 83;
			// 
			// txtPrezimeRadnika
			// 
			this.txtPrezimeRadnika.Font = new System.Drawing.Font("Candara", 12F);
			this.txtPrezimeRadnika.Location = new System.Drawing.Point(214, 103);
			this.txtPrezimeRadnika.Name = "txtPrezimeRadnika";
			this.txtPrezimeRadnika.Size = new System.Drawing.Size(296, 27);
			this.txtPrezimeRadnika.TabIndex = 82;
			// 
			// txtImeRadnika
			// 
			this.txtImeRadnika.Font = new System.Drawing.Font("Candara", 12F);
			this.txtImeRadnika.Location = new System.Drawing.Point(214, 61);
			this.txtImeRadnika.Name = "txtImeRadnika";
			this.txtImeRadnika.Size = new System.Drawing.Size(296, 27);
			this.txtImeRadnika.TabIndex = 81;
			// 
			// lblKvalifikacije
			// 
			this.lblKvalifikacije.AutoSize = true;
			this.lblKvalifikacije.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblKvalifikacije.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblKvalifikacije.Location = new System.Drawing.Point(16, 248);
			this.lblKvalifikacije.Name = "lblKvalifikacije";
			this.lblKvalifikacije.Size = new System.Drawing.Size(112, 23);
			this.lblKvalifikacije.TabIndex = 79;
			this.lblKvalifikacije.Text = "Kvalifikacije:";
			// 
			// lblMesto
			// 
			this.lblMesto.AutoSize = true;
			this.lblMesto.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblMesto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMesto.Location = new System.Drawing.Point(16, 288);
			this.lblMesto.Name = "lblMesto";
			this.lblMesto.Size = new System.Drawing.Size(67, 23);
			this.lblMesto.TabIndex = 74;
			this.lblMesto.Text = "Mesto:";
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnIzmeni.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnIzmeni.Location = new System.Drawing.Point(20, 378);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(261, 46);
			this.btnIzmeni.TabIndex = 76;
			this.btnIzmeni.Text = "Izmeni radnika";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
			// 
			// lblUlica
			// 
			this.lblUlica.AutoSize = true;
			this.lblUlica.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblUlica.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUlica.Location = new System.Drawing.Point(16, 196);
			this.lblUlica.Name = "lblUlica";
			this.lblUlica.Size = new System.Drawing.Size(55, 23);
			this.lblUlica.TabIndex = 78;
			this.lblUlica.Text = "Ulica:";
			// 
			// lblImeRadnika
			// 
			this.lblImeRadnika.AutoSize = true;
			this.lblImeRadnika.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblImeRadnika.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblImeRadnika.Location = new System.Drawing.Point(16, 61);
			this.lblImeRadnika.Name = "lblImeRadnika";
			this.lblImeRadnika.Size = new System.Drawing.Size(110, 23);
			this.lblImeRadnika.TabIndex = 73;
			this.lblImeRadnika.Text = "Ime radnika:";
			// 
			// lblJMBG
			// 
			this.lblJMBG.AutoSize = true;
			this.lblJMBG.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblJMBG.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblJMBG.Location = new System.Drawing.Point(16, 152);
			this.lblJMBG.Name = "lblJMBG";
			this.lblJMBG.Size = new System.Drawing.Size(62, 23);
			this.lblJMBG.TabIndex = 77;
			this.lblJMBG.Text = "JMBG:";
			// 
			// lblPrezimeRadnika
			// 
			this.lblPrezimeRadnika.AutoSize = true;
			this.lblPrezimeRadnika.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblPrezimeRadnika.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPrezimeRadnika.Location = new System.Drawing.Point(16, 103);
			this.lblPrezimeRadnika.Name = "lblPrezimeRadnika";
			this.lblPrezimeRadnika.Size = new System.Drawing.Size(146, 23);
			this.lblPrezimeRadnika.TabIndex = 75;
			this.lblPrezimeRadnika.Text = "Prezime radnika:";
			// 
			// FrmDetaljiRadnika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(618, 478);
			this.Controls.Add(this.gbPodaciRadnika);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDetaljiRadnika";
			this.Text = "[Preduzece \"MNDJ\"] - Detalji radnika";
			this.Load += new System.EventHandler(this.FrmDetaljiRadnika_Load);
			this.gbPodaciRadnika.ResumeLayout(false);
			this.gbPodaciRadnika.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPodaciRadnika;
		private System.Windows.Forms.Button btnObrisiRadnika;
		private System.Windows.Forms.Label lblPol;
		private System.Windows.Forms.ComboBox cmbMesto;
		private System.Windows.Forms.ComboBox cmbKvalifikacije;
		private System.Windows.Forms.TextBox txtUlica;
		private System.Windows.Forms.TextBox txtJMBG;
		private System.Windows.Forms.TextBox txtPrezimeRadnika;
		private System.Windows.Forms.TextBox txtImeRadnika;
		private System.Windows.Forms.Label lblKvalifikacije;
		private System.Windows.Forms.Label lblMesto;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.Label lblUlica;
		private System.Windows.Forms.Label lblImeRadnika;
		private System.Windows.Forms.Label lblJMBG;
		private System.Windows.Forms.Label lblPrezimeRadnika;
		private System.Windows.Forms.CheckBox cbMuski;
		private System.Windows.Forms.CheckBox cbZenski;
	}
}