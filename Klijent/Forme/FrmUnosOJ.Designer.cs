namespace Klijent
{
	partial class FrmUnosOJ
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosOJ));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnObrisi = new System.Windows.Forms.Button();
			this.btnDodajRM = new System.Windows.Forms.Button();
			this.lblKvalifikacije = new System.Windows.Forms.Label();
			this.cmbRadnik = new System.Windows.Forms.ComboBox();
			this.lblRadnik = new System.Windows.Forms.Label();
			this.lblNaziv = new System.Windows.Forms.Label();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.txtNazivOJ = new System.Windows.Forms.TextBox();
			this.lblNazivOJ = new System.Windows.Forms.Label();
			this.gbRM = new System.Windows.Forms.GroupBox();
			this.txtKvalifikacije = new System.Windows.Forms.TextBox();
			this.btnSacuvaj = new System.Windows.Forms.Button();
			this.btnKreiraj = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbRM.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(9, 101);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10F);
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Size = new System.Drawing.Size(638, 272);
			this.dataGridView1.TabIndex = 32;
			// 
			// btnObrisi
			// 
			this.btnObrisi.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.btnObrisi.Location = new System.Drawing.Point(172, 72);
			this.btnObrisi.Name = "btnObrisi";
			this.btnObrisi.Size = new System.Drawing.Size(140, 23);
			this.btnObrisi.TabIndex = 31;
			this.btnObrisi.Text = "Obriši radno mesto";
			this.btnObrisi.UseVisualStyleBackColor = true;
			this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
			// 
			// btnDodajRM
			// 
			this.btnDodajRM.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.btnDodajRM.Location = new System.Drawing.Point(6, 72);
			this.btnDodajRM.Name = "btnDodajRM";
			this.btnDodajRM.Size = new System.Drawing.Size(141, 23);
			this.btnDodajRM.TabIndex = 30;
			this.btnDodajRM.Text = "Dodaj radno mesto";
			this.btnDodajRM.UseVisualStyleBackColor = true;
			this.btnDodajRM.Click += new System.EventHandler(this.btnDodajRM_Click);
			// 
			// lblKvalifikacije
			// 
			this.lblKvalifikacije.AutoSize = true;
			this.lblKvalifikacije.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.lblKvalifikacije.Location = new System.Drawing.Point(491, 35);
			this.lblKvalifikacije.Name = "lblKvalifikacije";
			this.lblKvalifikacije.Size = new System.Drawing.Size(82, 17);
			this.lblKvalifikacije.TabIndex = 29;
			this.lblKvalifikacije.Text = "Kvalifikacije:";
			// 
			// cmbRadnik
			// 
			this.cmbRadnik.Font = new System.Drawing.Font("Candara", 11F);
			this.cmbRadnik.FormattingEnabled = true;
			this.cmbRadnik.Location = new System.Drawing.Point(295, 31);
			this.cmbRadnik.Name = "cmbRadnik";
			this.cmbRadnik.Size = new System.Drawing.Size(190, 26);
			this.cmbRadnik.TabIndex = 27;
			this.cmbRadnik.SelectedIndexChanged += new System.EventHandler(this.cmbRadnik_SelectedIndexChanged);
			// 
			// lblRadnik
			// 
			this.lblRadnik.AutoSize = true;
			this.lblRadnik.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.lblRadnik.Location = new System.Drawing.Point(236, 35);
			this.lblRadnik.Name = "lblRadnik";
			this.lblRadnik.Size = new System.Drawing.Size(53, 17);
			this.lblRadnik.TabIndex = 26;
			this.lblRadnik.Text = "Radnik:";
			// 
			// lblNaziv
			// 
			this.lblNaziv.AutoSize = true;
			this.lblNaziv.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.lblNaziv.Location = new System.Drawing.Point(6, 34);
			this.lblNaziv.Name = "lblNaziv";
			this.lblNaziv.Size = new System.Drawing.Size(44, 17);
			this.lblNaziv.TabIndex = 25;
			this.lblNaziv.Text = "Naziv:";
			// 
			// txtNaziv
			// 
			this.txtNaziv.Font = new System.Drawing.Font("Candara", 11F);
			this.txtNaziv.Location = new System.Drawing.Point(56, 32);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(177, 25);
			this.txtNaziv.TabIndex = 24;
			// 
			// txtNazivOJ
			// 
			this.txtNazivOJ.Font = new System.Drawing.Font("Candara", 11F);
			this.txtNazivOJ.Location = new System.Drawing.Point(208, 26);
			this.txtNazivOJ.Multiline = true;
			this.txtNazivOJ.Name = "txtNazivOJ";
			this.txtNazivOJ.Size = new System.Drawing.Size(210, 25);
			this.txtNazivOJ.TabIndex = 0;
			// 
			// lblNazivOJ
			// 
			this.lblNazivOJ.AutoSize = true;
			this.lblNazivOJ.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.lblNazivOJ.Location = new System.Drawing.Point(23, 28);
			this.lblNazivOJ.Name = "lblNazivOJ";
			this.lblNazivOJ.Size = new System.Drawing.Size(179, 17);
			this.lblNazivOJ.TabIndex = 1;
			this.lblNazivOJ.Text = "Naziv organizacione jedinice:";
			// 
			// gbRM
			// 
			this.gbRM.Controls.Add(this.txtKvalifikacije);
			this.gbRM.Controls.Add(this.txtNaziv);
			this.gbRM.Controls.Add(this.dataGridView1);
			this.gbRM.Controls.Add(this.lblNaziv);
			this.gbRM.Controls.Add(this.btnObrisi);
			this.gbRM.Controls.Add(this.lblRadnik);
			this.gbRM.Controls.Add(this.btnDodajRM);
			this.gbRM.Controls.Add(this.cmbRadnik);
			this.gbRM.Controls.Add(this.lblKvalifikacije);
			this.gbRM.Enabled = false;
			this.gbRM.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.gbRM.Location = new System.Drawing.Point(26, 61);
			this.gbRM.Name = "gbRM";
			this.gbRM.Size = new System.Drawing.Size(653, 391);
			this.gbRM.TabIndex = 0;
			this.gbRM.TabStop = false;
			this.gbRM.Text = "Podaci o radnim mestima";
			// 
			// txtKvalifikacije
			// 
			this.txtKvalifikacije.Enabled = false;
			this.txtKvalifikacije.Font = new System.Drawing.Font("Candara", 11F);
			this.txtKvalifikacije.Location = new System.Drawing.Point(579, 31);
			this.txtKvalifikacije.Name = "txtKvalifikacije";
			this.txtKvalifikacije.Size = new System.Drawing.Size(68, 25);
			this.txtKvalifikacije.TabIndex = 33;
			// 
			// btnSacuvaj
			// 
			this.btnSacuvaj.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnSacuvaj.Location = new System.Drawing.Point(26, 458);
			this.btnSacuvaj.Name = "btnSacuvaj";
			this.btnSacuvaj.Size = new System.Drawing.Size(653, 31);
			this.btnSacuvaj.TabIndex = 33;
			this.btnSacuvaj.Text = "Sačuvaj";
			this.btnSacuvaj.UseVisualStyleBackColor = true;
			this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
			// 
			// btnKreiraj
			// 
			this.btnKreiraj.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
			this.btnKreiraj.Location = new System.Drawing.Point(424, 26);
			this.btnKreiraj.Name = "btnKreiraj";
			this.btnKreiraj.Size = new System.Drawing.Size(124, 25);
			this.btnKreiraj.TabIndex = 34;
			this.btnKreiraj.Text = "Kreiraj";
			this.btnKreiraj.UseVisualStyleBackColor = true;
			this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
			// 
			// FrmUnosOJ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(704, 494);
			this.Controls.Add(this.btnKreiraj);
			this.Controls.Add(this.btnSacuvaj);
			this.Controls.Add(this.lblNazivOJ);
			this.Controls.Add(this.txtNazivOJ);
			this.Controls.Add(this.gbRM);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmUnosOJ";
			this.Text = "[Preduzece \"MNDJ\"] - Organizaciona jedinica";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbRM.ResumeLayout(false);
			this.gbRM.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnObrisi;
		private System.Windows.Forms.Button btnDodajRM;
		private System.Windows.Forms.Label lblKvalifikacije;
		private System.Windows.Forms.ComboBox cmbRadnik;
		private System.Windows.Forms.Label lblRadnik;
		private System.Windows.Forms.Label lblNaziv;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.TextBox txtNazivOJ;
		private System.Windows.Forms.Label lblNazivOJ;
		private System.Windows.Forms.GroupBox gbRM;
		private System.Windows.Forms.Button btnSacuvaj;
		private System.Windows.Forms.Button btnKreiraj;
		private System.Windows.Forms.TextBox txtKvalifikacije;
	}
}