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
	public partial class FrmUnosOJ : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmUnosOJ()
		{
			InitializeComponent();
		}

		private void btnKreiraj_Click(object sender, EventArgs e)
		{
			if (txtNazivOJ.Text == "")
			{
				MessageBox.Show("Morate uneti naziv organizacione jedinice!");
				return;
			}
			kontroler.kreirajOJ(txtNaziv, gbRM, dataGridView1, cmbRadnik, btnKreiraj, txtKvalifikacije);
		}

		private void btnDodajRM_Click(object sender, EventArgs e)
		{
			kontroler.dodajRM(txtNaziv, cmbRadnik, txtKvalifikacije, txtNazivOJ);
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (kontroler.zapamtiOJ(txtNazivOJ)) this.Close();
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			kontroler.obrisiRM(dataGridView1);
		}

		private void cmbRadnik_SelectedIndexChanged(object sender, EventArgs e)
		{
			kontroler.popuniPoljaRadnogMesta(cmbRadnik, txtKvalifikacije);
		}
	}
}
