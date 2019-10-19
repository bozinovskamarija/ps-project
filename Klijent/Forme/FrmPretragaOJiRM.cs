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
	public partial class FrmPretragaOJiRM : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmPretragaOJiRM()
		{
			InitializeComponent();
		}

		private void txtPretraga_TextChanged(object sender, EventArgs e)
		{
			kontroler.pretraziOJiRM(txtPretraga, dgvPretraga);
		}

		private void FrmPretragaOJiRM_Load(object sender, EventArgs e)
		{
			kontroler.pretraziOJiRM(txtPretraga, dgvPretraga);
		}

		private void dgvPretraga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (kontroler.pronadjiOJiRM(dgvPretraga)) new FrmDetaljiOJiRM().ShowDialog();
			txtPretraga_TextChanged(sender, e);
		}
	}
}
