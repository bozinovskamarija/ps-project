namespace Server
{
	partial class FormaServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServer));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnPokreni = new System.Windows.Forms.Button();
			this.btnZaustavi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnPokreni
			// 
			this.btnPokreni.ForeColor = System.Drawing.Color.Gray;
			this.btnPokreni.Image = ((System.Drawing.Image)(resources.GetObject("btnPokreni.Image")));
			this.btnPokreni.Location = new System.Drawing.Point(40, 44);
			this.btnPokreni.Name = "btnPokreni";
			this.btnPokreni.Size = new System.Drawing.Size(295, 270);
			this.btnPokreni.TabIndex = 4;
			this.btnPokreni.UseVisualStyleBackColor = true;
			this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
			// 
			// btnZaustavi
			// 
			this.btnZaustavi.ForeColor = System.Drawing.Color.Gray;
			this.btnZaustavi.Image = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.Image")));
			this.btnZaustavi.Location = new System.Drawing.Point(341, 44);
			this.btnZaustavi.Name = "btnZaustavi";
			this.btnZaustavi.Size = new System.Drawing.Size(268, 270);
			this.btnZaustavi.TabIndex = 5;
			this.btnZaustavi.UseVisualStyleBackColor = true;
			this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
			// 
			// FormaServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(653, 362);
			this.Controls.Add(this.btnZaustavi);
			this.Controls.Add(this.btnPokreni);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.Name = "FormaServer";
			this.Text = "[Preduzece \"MNDJ\"] - Serverska aplikacija";
			this.Load += new System.EventHandler(this.FormaServer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btnPokreni;
		private System.Windows.Forms.Button btnZaustavi;
	}
}

