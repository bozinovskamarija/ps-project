using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Server
{
	public partial class FormaServer : Form
	{
		Server s;
		public FormaServer()
		{
			InitializeComponent();
		}

		private void btnPokreni_Click(object sender, EventArgs e)
		{
			s = new Server();
			if (s.pokreniServer())
			{
				this.Text = "Server: uključen!";
				btnPokreni.Enabled = false;
				btnZaustavi.Enabled = true;
			}
		}

		private void FormaServer_Load(object sender, EventArgs e)
		{
			btnPokreni.BackColor = Color.Gray;
			btnZaustavi.BackColor = Color.Gray;
		}

		private void btnZaustavi_Click(object sender, EventArgs e)
		{
			//if (Server.listaTokovaKlijenata.Count > 0)
			//{
			//	MessageBox.Show("Ima i dalje ulogovanih klijenata!");
			//	return;
			//}

			if (s.zaustaviServer())
			{
				this.Text = "Server je isključen!";
				btnPokreni.Enabled = true;
				btnZaustavi.Enabled = false;
			}
		}
	}
}
