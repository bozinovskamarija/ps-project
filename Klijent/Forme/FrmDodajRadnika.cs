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
	public partial class FrmDodajRadnika : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmDodajRadnika()
		{
			InitializeComponent();
		}

		private void FrmUnosRadnika_Load(object sender, EventArgs e)
		{
			kontroler.ucitajListuMesta(cmbMesto);
			cmbMesto.Text = "Izaberite mesto!";

			kontroler.ucitajListuKvalifikacija(cmbKvalifikacije);
			cmbKvalifikacije.Text = "Izaberite kvalifikacije!";		
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (kontroler.zapamtiRadnika(cmbKvalifikacije, cmbMesto, txtImeRadnika, txtPrezimeRadnika, txtJMBG, txtUlica, cbMuski, cbZenski))
				this.Close();
		}
	}
}
