namespace Klijent
{
	partial class FrmDetaljiOJiRM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetaljiOJiRM));
			this.lblNazivOJ = new System.Windows.Forms.Label();
			this.gbRM = new System.Windows.Forms.GroupBox();
			this.btnObrisiRM = new System.Windows.Forms.Button();
			this.dgvDetaljiRM = new System.Windows.Forms.DataGridView();
			this.btnObrisiOJ = new System.Windows.Forms.Button();
			this.txtNazivOJ = new System.Windows.Forms.TextBox();
			this.gbRM.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiRM)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNazivOJ
			// 
			this.lblNazivOJ.AutoSize = true;
			this.lblNazivOJ.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
			this.lblNazivOJ.Location = new System.Drawing.Point(21, 12);
			this.lblNazivOJ.Name = "lblNazivOJ";
			this.lblNazivOJ.Size = new System.Drawing.Size(207, 19);
			this.lblNazivOJ.TabIndex = 37;
			this.lblNazivOJ.Text = "Naziv organizacione jedinice:";
			// 
			// gbRM
			// 
			this.gbRM.Controls.Add(this.btnObrisiRM);
			this.gbRM.Controls.Add(this.dgvDetaljiRM);
			this.gbRM.Controls.Add(this.btnObrisiOJ);
			this.gbRM.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			this.gbRM.Location = new System.Drawing.Point(15, 42);
			this.gbRM.Name = "gbRM";
			this.gbRM.Size = new System.Drawing.Size(653, 259);
			this.gbRM.TabIndex = 36;
			this.gbRM.TabStop = false;
			this.gbRM.Text = "Podaci o radnim mestima";
			// 
			// btnObrisiRM
			// 
			this.btnObrisiRM.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnObrisiRM.Location = new System.Drawing.Point(384, 220);
			this.btnObrisiRM.Name = "btnObrisiRM";
			this.btnObrisiRM.Size = new System.Drawing.Size(263, 33);
			this.btnObrisiRM.TabIndex = 41;
			this.btnObrisiRM.Text = "Obriši radno mesto ";
			this.btnObrisiRM.UseVisualStyleBackColor = true;
			this.btnObrisiRM.Click += new System.EventHandler(this.btnObrisiRM_Click);
			// 
			// dgvDetaljiRM
			// 
			this.dgvDetaljiRM.AllowUserToAddRows = false;
			this.dgvDetaljiRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDetaljiRM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvDetaljiRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetaljiRM.Location = new System.Drawing.Point(6, 19);
			this.dgvDetaljiRM.Name = "dgvDetaljiRM";
			this.dgvDetaljiRM.RowHeadersVisible = false;
			this.dgvDetaljiRM.Size = new System.Drawing.Size(641, 195);
			this.dgvDetaljiRM.TabIndex = 40;
			// 
			// btnObrisiOJ
			// 
			this.btnObrisiOJ.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.btnObrisiOJ.Location = new System.Drawing.Point(6, 220);
			this.btnObrisiOJ.Name = "btnObrisiOJ";
			this.btnObrisiOJ.Size = new System.Drawing.Size(279, 33);
			this.btnObrisiOJ.TabIndex = 39;
			this.btnObrisiOJ.Text = "Obriši organizacionu jedinicu";
			this.btnObrisiOJ.UseVisualStyleBackColor = true;
			this.btnObrisiOJ.Click += new System.EventHandler(this.btnObrisiOJ_Click);
			// 
			// txtNazivOJ
			// 
			this.txtNazivOJ.Font = new System.Drawing.Font("Candara", 11F);
			this.txtNazivOJ.Location = new System.Drawing.Point(234, 13);
			this.txtNazivOJ.Name = "txtNazivOJ";
			this.txtNazivOJ.Size = new System.Drawing.Size(267, 25);
			this.txtNazivOJ.TabIndex = 38;
			// 
			// FrmDetaljiOJiRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(682, 307);
			this.Controls.Add(this.txtNazivOJ);
			this.Controls.Add(this.lblNazivOJ);
			this.Controls.Add(this.gbRM);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDetaljiOJiRM";
			this.Text = "[Preduzece \"MNDJ\"] - Detalji organizacionih jedinica i radnih mesta";
			this.Load += new System.EventHandler(this.FrmDetaljiOJiRM_Load);
			this.gbRM.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiRM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblNazivOJ;
		private System.Windows.Forms.GroupBox gbRM;
		private System.Windows.Forms.Button btnObrisiOJ;
		private System.Windows.Forms.DataGridView dgvDetaljiRM;
		private System.Windows.Forms.TextBox txtNazivOJ;
		private System.Windows.Forms.Button btnObrisiRM;
	}
}