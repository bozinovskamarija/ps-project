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
	public partial class FrmPretragaUgovoraORadu : Form
	{
		KontrolerKI kontroler = new KontrolerKI();

		public FrmPretragaUgovoraORadu()
		{
			InitializeComponent();
		}

		private void FrmPretragaUgovoraORadu_Load(object sender, EventArgs e)
		{
			kontroler.vratiUgovoreZaUslov(txtPretraga, dgvPretraga);
		}

		private void txtPretraga_TextChanged(object sender, EventArgs e)
		{
			kontroler.vratiUgovoreZaUslov(txtPretraga, dgvPretraga);
		}
	}
}
