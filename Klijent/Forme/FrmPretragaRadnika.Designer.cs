namespace Klijent
{
	partial class FrmPretragaRadnika
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaRadnika));
			this.lblPretraga = new System.Windows.Forms.Label();
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.dgvPretraga = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPretraga
			// 
			this.lblPretraga.AutoSize = true;
			this.lblPretraga.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblPretraga.Location = new System.Drawing.Point(8, 9);
			this.lblPretraga.Name = "lblPretraga";
			this.lblPretraga.Size = new System.Drawing.Size(248, 23);
			this.lblPretraga.TabIndex = 0;
			this.lblPretraga.Text = "Unesi ključnu reč za pretragu:";
			// 
			// txtPretraga
			// 
			this.txtPretraga.Font = new System.Drawing.Font("Candara", 12F);
			this.txtPretraga.Location = new System.Drawing.Point(262, 9);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(286, 27);
			this.txtPretraga.TabIndex = 1;
			this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
			// 
			// dgvPretraga
			// 
			this.dgvPretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPretraga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPretraga.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPretraga.Location = new System.Drawing.Point(13, 52);
			this.dgvPretraga.Name = "dgvPretraga";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPretraga.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPretraga.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 10F);
			this.dgvPretraga.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPretraga.Size = new System.Drawing.Size(602, 350);
			this.dgvPretraga.TabIndex = 2;
			this.dgvPretraga.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellDoubleClick);
			// 
			// FrmPretragaRadnika
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(627, 414);
			this.Controls.Add(this.dgvPretraga);
			this.Controls.Add(this.txtPretraga);
			this.Controls.Add(this.lblPretraga);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPretragaRadnika";
			this.Text = "[Preduzece \"MNDJ\"] - Pretraga radnika";
			this.Load += new System.EventHandler(this.FrmPretragaRadnika_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPretraga;
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.DataGridView dgvPretraga;
	}
}