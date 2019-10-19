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
	public partial class FrmGlavniMeni : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmGlavniMeni()
		{
			InitializeComponent();
		}

		private void FrmGlavniMeni_Load(object sender, EventArgs e)
		{
			lblZaposleni.Text = KontrolerKI.zaposleni.ToString();
		}

		private void dodavanjeNovogRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmDodajRadnika().ShowDialog();
		}

		private void pretragaRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmPretragaRadnika().ShowDialog();
		}

		private void dodavanjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmDodajUgovorORadu().ShowDialog();
		}

		private void pretragaUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmPretragaUgovoraORadu().ShowDialog();
		}

		private void dodavanjeNoveOrganizacioneJediniceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmUnosOJ().ShowDialog();

		}

		private void FrmGlavniMeni_FormClosed(object sender, FormClosedEventArgs e)
		{
			kontroler.kraj();
		}

		private void pretragaOrganizacioneJediniceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmPretragaOJiRM().ShowDialog();
		}
	}
}
