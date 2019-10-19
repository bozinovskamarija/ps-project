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
	public partial class FrmPretragaRadnika : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmPretragaRadnika()
		{
			InitializeComponent();
		}

		private void FrmPretragaRadnika_Load(object sender, EventArgs e)
		{
			kontroler.pretraziRadnike(txtPretraga, dgvPretraga);
		}

		private void txtPretraga_TextChanged(object sender, EventArgs e)
		{
			kontroler.pretraziRadnike(txtPretraga, dgvPretraga);
		}

		private void dgvPretraga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (kontroler.ucitajRadnika(dgvPretraga)) new FrmDetaljiRadnika().ShowDialog();
			txtPretraga_TextChanged(sender, e);
		}

		private void btnObrisiRadnika_Click(object sender, EventArgs e)
		{
			if (kontroler.obrisiRadnika()) this.Close();
		}	
	}
}
