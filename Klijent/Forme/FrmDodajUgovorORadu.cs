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
	public partial class FrmDodajUgovorORadu : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmDodajUgovorORadu()
		{
			InitializeComponent();
		}

		private void FrmDodajUgovorORadu_Load(object sender, EventArgs e)
		{
			kontroler.ucitajListuRadnihMesta(cmbRadnoMesto);
			cmbRadnoMesto.Text = "Izaberite radno mesto!";

			kontroler.ucitajListuRadnika(cmbRadnik);
			cmbRadnik.Text = "Izaberite radnika!";

			txtOJ.Text = "Organizaciona jedinica!";

			dtpSklapanje.CustomFormat = "dd / MM / yyyy";
			dtpUkidanja.CustomFormat = "dd / MM / yyyy";
		}

		private void btnDodaj_Click(object sender, EventArgs e)
		{
			if (kontroler.zapamtiUgovorORadu(dtpSklapanje, dtpUkidanja, txtTip, txtNapomena, cmbRadnik, cmbRadnoMesto, txtOJ))
				this.Close();
		}

		private void cmbRadnoMesto_SelectionChangeCommitted(object sender, EventArgs e)
		{
			kontroler.popuniPoljaUgovora(txtOJ, cmbRadnoMesto);
		}
	}
}
