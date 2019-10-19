namespace Klijent
{
	partial class FrmPretragaUgovoraORadu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaUgovoraORadu));
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.lblPretraga = new System.Windows.Forms.Label();
			this.dgvPretraga = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Font = new System.Drawing.Font("Candara", 12F);
			this.txtPretraga.Location = new System.Drawing.Point(269, 15);
			this.txtPretraga.Margin = new System.Windows.Forms.Padding(6);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(532, 27);
			this.txtPretraga.TabIndex = 4;
			this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
			// 
			// lblPretraga
			// 
			this.lblPretraga.AutoSize = true;
			this.lblPretraga.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.lblPretraga.Location = new System.Drawing.Point(18, 15);
			this.lblPretraga.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblPretraga.Name = "lblPretraga";
			this.lblPretraga.Size = new System.Drawing.Size(248, 23);
			this.lblPretraga.TabIndex = 3;
			this.lblPretraga.Text = "Unesi ključnu reč za pretragu:";
			// 
			// dgvPretraga
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10F);
			this.dgvPretraga.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPretraga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPretraga.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPretraga.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPretraga.Location = new System.Drawing.Point(22, 51);
			this.dgvPretraga.Name = "dgvPretraga";
			this.dgvPretraga.RowHeadersVisible = false;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 10F);
			this.dgvPretraga.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPretraga.Size = new System.Drawing.Size(779, 333);
			this.dgvPretraga.TabIndex = 5;
			// 
			// FrmPretragaUgovoraORadu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(822, 396);
			this.Controls.Add(this.dgvPretraga);
			this.Controls.Add(this.txtPretraga);
			this.Controls.Add(this.lblPretraga);
			this.Font = new System.Drawing.Font("Candara", 15.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FrmPretragaUgovoraORadu";
			this.Text = "[Preduzece \"MNDJ\"] - Pretraga ugovora o radu";
			this.Load += new System.EventHandler(this.FrmPretragaUgovoraORadu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Label lblPretraga;
		private System.Windows.Forms.DataGridView dgvPretraga;
	}
}