namespace Klijent
{
	partial class FrmPrijavljivanje
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijavljivanje));
			this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
			this.txtKorisnickaSifra = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPrijaviSe = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnVidljivost = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKorisnickoIme
			// 
			this.txtKorisnickoIme.Font = new System.Drawing.Font("Candara", 12F);
			this.txtKorisnickoIme.Location = new System.Drawing.Point(183, 45);
			this.txtKorisnickoIme.Name = "txtKorisnickoIme";
			this.txtKorisnickoIme.Size = new System.Drawing.Size(267, 27);
			this.txtKorisnickoIme.TabIndex = 0;
			this.txtKorisnickoIme.Text = "mara";
			// 
			// txtKorisnickaSifra
			// 
			this.txtKorisnickaSifra.Font = new System.Drawing.Font("Candara", 12F);
			this.txtKorisnickaSifra.Location = new System.Drawing.Point(183, 91);
			this.txtKorisnickaSifra.Name = "txtKorisnickaSifra";
			this.txtKorisnickaSifra.Size = new System.Drawing.Size(267, 27);
			this.txtKorisnickaSifra.TabIndex = 1;
			this.txtKorisnickaSifra.Text = "mara";
			this.txtKorisnickaSifra.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Korisničko ime:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(56, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Korisnička šifra:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnPrijaviSe
			// 
			this.btnPrijaviSe.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnPrijaviSe.Location = new System.Drawing.Point(183, 134);
			this.btnPrijaviSe.Name = "btnPrijaviSe";
			this.btnPrijaviSe.Size = new System.Drawing.Size(182, 31);
			this.btnPrijaviSe.TabIndex = 4;
			this.btnPrijaviSe.Text = "Prijavi se!";
			this.btnPrijaviSe.UseVisualStyleBackColor = true;
			this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(22, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 35);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(22, 45);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(38, 32);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// btnVidljivost
			// 
			this.btnVidljivost.BackColor = System.Drawing.Color.Transparent;
			this.btnVidljivost.Image = ((System.Drawing.Image)(resources.GetObject("btnVidljivost.Image")));
			this.btnVidljivost.Location = new System.Drawing.Point(456, 88);
			this.btnVidljivost.Name = "btnVidljivost";
			this.btnVidljivost.Size = new System.Drawing.Size(43, 33);
			this.btnVidljivost.TabIndex = 7;
			this.btnVidljivost.UseVisualStyleBackColor = false;
			this.btnVidljivost.Click += new System.EventHandler(this.btnVidljivost_Click);
			// 
			// FrmPrijavljivanje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(553, 215);
			this.Controls.Add(this.btnVidljivost);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPrijaviSe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtKorisnickaSifra);
			this.Controls.Add(this.txtKorisnickoIme);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPrijavljivanje";
			this.Text = "[Preduzece \"MNDJ\"] - Prijavljivanje na sistem";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKorisnickoIme;
		private System.Windows.Forms.TextBox txtKorisnickaSifra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPrijaviSe;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnVidljivost;
	}
}