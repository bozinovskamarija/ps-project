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
	public partial class FrmDetaljiOJiRM : Form
	{
		KontrolerKI kontroler = new KontrolerKI();
		public FrmDetaljiOJiRM()
		{
			InitializeComponent();
			
		}

		private void FrmDetaljiOJiRM_Load(object sender, EventArgs e)
		{
			kontroler.popuniPoljaRMiOJ(txtNazivOJ,dgvDetaljiRM);
			dgvDetaljiRM.Columns[3].Visible = false;
		}

		private void btnObrisiRM_Click(object sender, EventArgs e)
		{

			if (dgvDetaljiRM.Rows.Count == 1)
			{
				DialogResult dialog = MessageBox.Show("Da li ste sigurni da želite da obrišete radno mesto? Ako obrišete radno mesto obrisaćete i celu organizacionu jedinicu!", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				kontroler.obrisiOJiRm();
				this.Close();
			}
			else if (kontroler.obrisiRMIzBaze(dgvDetaljiRM))
			{
				this.Close();
			}
		}

		private void btnObrisiOJ_Click(object sender, EventArgs e)
		{
			if (kontroler.obrisiOJiRm()) this.Close();
		}


	}
}
