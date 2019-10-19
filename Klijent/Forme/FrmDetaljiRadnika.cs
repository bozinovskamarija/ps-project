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
	public partial class FrmDetaljiRadnika : Form
	{
		KontrolerKI kontroler = new KontrolerKI();
		public FrmDetaljiRadnika()
		{
			InitializeComponent();
		}

		private void FrmDetaljiRadnika_Load(object sender, EventArgs e)
		{
			kontroler.popuniPoljaRadnika(cmbKvalifikacije, cmbMesto, txtImeRadnika, txtPrezimeRadnika, txtJMBG, txtUlica, cbMuski, cbZenski);
		}

		private void btnObrisiRadnika_Click(object sender, EventArgs e)
		{
			if (kontroler.obrisiRadnika()) this.Close();
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			if (kontroler.azurirajRadnika(cmbKvalifikacije, cmbMesto, txtImeRadnika, txtPrezimeRadnika, txtJMBG, txtUlica, cbMuski, cbZenski))

				this.Close();
		}
	}
}
