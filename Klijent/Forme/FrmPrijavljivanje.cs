using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
	public partial class FrmPrijavljivanje : Form
	{
		KontrolerKI kontroler = new KontrolerKI();
		public FrmPrijavljivanje()
		{
			InitializeComponent();
		}

		private void FrmPrijavljivanje_FormClosed(object sender, FormClosedEventArgs e)
		{
			kontroler.kraj();
		}

		private void btnPrijaviSe_Click(object sender, EventArgs e)
		{
			this.Text = KontrolerKI.poveziSeNaServer();
			if (kontroler.pronadjiZaposlenog(txtKorisnickoIme, txtKorisnickaSifra))
			{
				new FrmGlavniMeni().ShowDialog();
				this.Hide();
			}
		}

		private void btnVidljivost_Click(object sender, EventArgs e)
		{
			txtKorisnickaSifra.UseSystemPasswordChar = !txtKorisnickaSifra.UseSystemPasswordChar;
		}
	}
}
