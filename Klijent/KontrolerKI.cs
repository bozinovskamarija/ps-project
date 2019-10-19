using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Klijent
{
	public class KontrolerKI
	{
		static Komunikacija komunikacija;
		public static Zaposleni zaposleni;
		public static Radnik radnik;
		public static UgovorORadu ugovor;
		public static OrganizacionaJedinica oj;
		public static RadnoMesto rm;

		internal bool obrisiOJiRm()
		{
			Object rez = komunikacija.obrisiOJiRM(oj);
			if (rez == null)
			{
				MessageBox.Show("Sistem ne može da obriše organizacionu jedinicu i radna mesta!");
				return false;
			}
			else
			{
				MessageBox.Show("Sistem je uspešno obrisao organizacionu jedinicu i radna mesta!");
				return true;
			}
		}

		internal bool obrisiRMIzBaze(DataGridView dgvDetaljiRM)
		{
			try
			{
				RadnoMesto rm = dgvDetaljiRM.CurrentRow.DataBoundItem as RadnoMesto;

				oj.ListaRadnihMesta.Remove(rm);

				Object rez = komunikacija.obrisiRMIzBaze(rm);

				if (rez == null)
				{
					MessageBox.Show("Sistem ne može da obriše radno mesto!");
					return false;
				}
				else
				{
					MessageBox.Show("Sistem je uspešno obrisao radno mesto!");
					return true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Niste odabrali radno mesto brisanje!");
				return false;
			}
		}

		public static Kvalifikacije kv;

		public static string poveziSeNaServer()
		{
			komunikacija = new Komunikacija();
			if (komunikacija.poveziSeNaServer())
			{
				return "Zaposleni je povezan na server!";
			}
			else
			{
				return "Zaposleni nije povezan na server!";
			}
		}

		internal void popuniPoljaRMiOJ(TextBox txtNazivOJ, DataGridView dgvDetaljiRM)
		{
			txtNazivOJ.Text = rm.Oj.Naziv.ToString();
			oj.SifraOJ = rm.Oj.SifraOJ;
			dgvDetaljiRM.DataSource = rm.Oj.ListaRadnihMesta;

			dgvDetaljiRM.DataSource = komunikacija.ucitajSvaRadnaMestaZaOJ(oj);
		}

		internal bool pronadjiOJiRM(DataGridView dgvPretraga)
		{
			try
			{
				rm = dgvPretraga.CurrentRow.DataBoundItem as RadnoMesto;
				oj = rm.Oj;
				rm = komunikacija.pronadjiOJiRM(rm) as RadnoMesto;

				if (rm == null)
				{
					MessageBox.Show("Sistem ne može da učita podatke o organizacionoj jedinici i randim mestima!");
					return false;
				}
				else
				{
					MessageBox.Show("Sistem je uspešno učitao podatke o izabranoj organizacionoj jedinici i radnim mestima!");
					return true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Niste odabarali organizacionu jedinicu i radno mesto!");
				return false;
			}
		}

		internal void vratiUgovoreZaUslov(TextBox txtPretraga, DataGridView dgvPretraga)
		{
			string uslov = txtPretraga.Text;
			List<UgovorORadu> lista = komunikacija.vratiUgovoreZaUslov(uslov) as List<UgovorORadu>;

			dgvPretraga.DataSource = lista;

			if (lista == null)
			{
				MessageBox.Show("Sistem ne može da pronađe ugovore!");
				return;
			}
			if (lista.Count == 0)
			{
				MessageBox.Show("Na osnovu unetih vrednosti sistem ne može da pronađe nijedan odgovarajući ugovor.");
				return;
			}
		}

		internal void popuniPoljaRadnogMesta(ComboBox cmbRadnik, TextBox txtKvalifikacije)
		{
			radnik = cmbRadnik.SelectedItem as Radnik;
			txtKvalifikacije.Text = radnik.Kvalifikacije.KvalifikacijeID.ToString();
		}

		internal bool zapamtiOJ(TextBox txtNazivOJ)
		{
			oj.Naziv = txtNazivOJ.Text;

			if (txtNazivOJ.Text == "")
			{
				MessageBox.Show("Fali naziv organizacione jedinice!");
			}

			Object rez = komunikacija.zapamtiOJ(oj);
			if (rez == null)
			{
				MessageBox.Show("Sistem ne može da zapamti organizacionu jedinicu!");
				return false;
			}
			else
			{
				MessageBox.Show("Sistem je uspešno zapamtio organizacionu jedinicu!");
				return true;
			}
		}

		internal bool azurirajRadnika(ComboBox cmbKvalifikacije, ComboBox cmbMesto, TextBox txtImeRadnika, TextBox txtPrezimeRadnika, TextBox txtJMBG, TextBox txtUlica, CheckBox cbMuski, CheckBox cbZenski)
		{
			radnik.Kvalifikacije = cmbKvalifikacije.SelectedItem as Kvalifikacije;
			radnik.Mestoo = cmbMesto.SelectedItem as Mesto;

			if (cbMuski.Checked == true)
			{
				radnik.Pol = cbMuski.Text;
			}
			else
			{
				radnik.Pol = cbZenski.Text;
			}

			if (cbMuski.Checked == false && cbZenski.Checked == false)
			{
				MessageBox.Show("Niste odabrali pol!");
				return false;
			}


			if (cmbKvalifikacije.Text == "Izaberite kvalifikacije!")
			{
				MessageBox.Show("Niste odabrali kvalifikacije!");
				return false;
			}

			if (cmbMesto.Text == "Izaberite mesto!")
			{
				MessageBox.Show("Niste odabrali mesto!");
				return false;
			}

			radnik.Ime = txtImeRadnika.Text;
			radnik.Prezime = txtPrezimeRadnika.Text;
			radnik.Ulica = txtUlica.Text;
			radnik.Jmbg = txtJMBG.Text;

			if (radnik.Ime == "")
			{
				MessageBox.Show("Morate uneti ime radnika!");
				txtImeRadnika.Focus();
				return false;
			}

			if (radnik.Prezime == "")
			{
				MessageBox.Show("Morate uneti prezime radnika!");
				txtPrezimeRadnika.Focus();
				return false;
			}

			if (radnik.Ulica == "")
			{
				MessageBox.Show("Morate uneti ulicu za radnika!");
				txtUlica.Focus();
				return false;
			}

			if (radnik.Jmbg == "")
			{
				MessageBox.Show("Morate uneti JMBG za radnika!");
				txtJMBG.Focus();
				return false;
			}

			if (radnik.Jmbg.Length != 13)
			{
				MessageBox.Show("JMBG Radnika mora imati 13 cifara");
				txtJMBG.Focus();
				return false;
			}

			Object rez = komunikacija.azurirajRadnika(radnik);

			if (rez == null)
			{
				MessageBox.Show("Sistem ne može da zapamti radnika!");
				return false;
			}

			else
			{
				MessageBox.Show("Uspešno je zapamćen radnik!");
				return true;
			}
		}

		internal void popuniPoljaUgovora(TextBox txtOJ, ComboBox cmbRadnoMesto)
		{
			rm = cmbRadnoMesto.SelectedItem as RadnoMesto;
			txtOJ.Text = rm.Oj.SifraOJ.ToString();
		}

		internal void dodajRM(TextBox txtNaziv, ComboBox cmbRadnik, TextBox txtKvalifikacije,
			TextBox txtNazivOJ)
		{
			RadnoMesto rm = new RadnoMesto();

			rm.Oj = new OrganizacionaJedinica();
			rm.Oj.SifraOJ = oj.SifraOJ;
			rm.Sifra = oj.ListaRadnihMesta.Count + 1;

			rm.Radnik = cmbRadnik.SelectedItem as Radnik;
			if (cmbRadnik.Text == "")
			{
				MessageBox.Show("Niste uneli radnika!");
				return;
			}


			rm.Kvalifikacije = new Kvalifikacije();
			rm.Kvalifikacije1 = int.Parse(txtKvalifikacije.Text);

			if (rm.Kvalifikacije == null)
			{
				MessageBox.Show("Niste odabrali kvalifikacije!");
				return;
			}

			if (txtNaziv.Text == "")
			{
				MessageBox.Show("Niste uneli naziv radnog mesta!");
				return;
			}

			if (txtNazivOJ.Text == "")
			{
				MessageBox.Show("Niste uneli naziv organizacione jedinice!");
				return;
			}

			rm.Naziv = txtNaziv.Text;
			rm.Oj.Naziv = txtNazivOJ.Text;
			oj.ListaRadnihMesta.Add(rm);
		}

		internal void obrisiRM(DataGridView dataGridView1)
		{
			try
			{
				RadnoMesto rm = dataGridView1.CurrentRow.DataBoundItem as RadnoMesto;
				oj.ListaRadnihMesta.Remove(rm);

				int i = 1;
				foreach (RadnoMesto rm1 in oj.ListaRadnihMesta)
				{
					rm1.Sifra = i;
					i++;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Niste odabrali radno mesto za brisanje!");
			}
		}

		internal void kreirajOJ(TextBox txtNaziv, GroupBox gbRM, DataGridView dataGridView1, ComboBox cmbRadnik, Button btnKreiraj, TextBox txtKvalifikacije)
		{

			oj = komunikacija.kreirajOJ() as OrganizacionaJedinica;

			if (oj == null)
			{
				MessageBox.Show("Sistem ne može da kreira organizacionu jedinicu");
				return;
			}
			else
			{
				btnKreiraj.Enabled = false;
				gbRM.Enabled = true;
				dataGridView1.DataSource = oj.ListaRadnihMesta;
				ucitajListuRadnika(cmbRadnik);
				MessageBox.Show("Sistem je uspešno kreirao organizacionu jedinicu!");
			}
		}

		internal void ucitajListuRadnihMesta(ComboBox cmbRadnoMesto)
		{
			cmbRadnoMesto.DataSource = komunikacija.ucitajSvaRadnaMesta();
		}

		internal void ucitajListuRadnika(ComboBox cmbRadnik)
		{
			cmbRadnik.DataSource = komunikacija.ucitajSveRadnike();
		}

		internal void popuniPoljaRadnika(ComboBox cmbKvalifikacije, ComboBox cmbMesto, TextBox txtImeRadnika, TextBox txtPrezimeRadnika, TextBox txtJMBG, TextBox txtUlica, CheckBox cbMuski, CheckBox cbZenski)
		{
			cmbKvalifikacije.DataSource = komunikacija.ucitajSveKvalifikacije();
			cmbMesto.DataSource = komunikacija.ucitajSvaMesta();

			cmbKvalifikacije.Text = radnik.Kvalifikacije.ToString();
			cmbMesto.Text = radnik.Mestoo.ToString();

			if (radnik.Pol.ToString() == "Muški")
			{
				cbMuski.Checked = true;
			}
			else
			{
				cbZenski.Checked = true;
			}

			txtImeRadnika.Text = radnik.Ime;
			txtPrezimeRadnika.Text = radnik.Prezime;
			txtUlica.Text = radnik.Ulica;
			txtJMBG.Text = radnik.Jmbg;
		}

		internal bool zapamtiUgovorORadu(DateTimePicker dtpSklapanje, DateTimePicker dtpUkidanja, TextBox txtTip, TextBox txtNapomena, ComboBox cmbRadnik, ComboBox cmbRadnoMesto, TextBox txtOJ)
		{
			ugovor = new UgovorORadu();

			ugovor.Radnik = cmbRadnik.SelectedItem as Radnik;
			ugovor.Rm = cmbRadnoMesto.SelectedItem as RadnoMesto;

			string datumSklapanja = dtpSklapanje.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
			try
			{
				ugovor.DatumSklapanja = DateTime.ParseExact(datumSklapanja, "dd/MM/yyyy", CultureInfo.InvariantCulture);
			}
			catch (Exception)
			{
				MessageBox.Show("Datum sklapanja ugovora nije u dobrom formatu!");
				return false;
			}

			string datumUkidanja = dtpUkidanja.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
			try
			{
				ugovor.DatumUkidanja = DateTime.ParseExact(datumUkidanja, "dd/MM/yyyy", CultureInfo.InvariantCulture);
			}
			catch (Exception)
			{
				MessageBox.Show("Datum ukidanja ugovora nije u dobrom formatu!");
				return false;
			}

			if (ugovor.DatumUkidanja.Date < ugovor.DatumSklapanja.Date)
			{
				MessageBox.Show("Datum ukidanja ugovora mora biti posle datuma sklapanja ugovora!");
				return false;
			}


			if (cmbRadnik.Text == "Izaberite radnika!")
			{
				MessageBox.Show("Niste odabrali radnika!");
				return false;
			}

			if (cmbRadnoMesto.Text == "Izaberite radno mesto!")
			{
				MessageBox.Show("Niste odabrali radno mesto!");
				return false;
			}

			ugovor.TipUgovora = txtTip.Text;

			if (ugovor.TipUgovora == "")
			{
				MessageBox.Show("Morate uneti tip ugovora!");
				txtTip.Focus();
				return false;
			}

			ugovor.Napomena = txtNapomena.Text;
			ugovor.Oj = new OrganizacionaJedinica();
			ugovor.Oj.SifraOJ = int.Parse(txtOJ.Text);

			Object rez = komunikacija.zapamtiUgovor(ugovor);

			if (rez == null)
			{
				MessageBox.Show("Sistem ne može da zapamti ugovor!");
				return false;
			}

			else
			{
				MessageBox.Show("Uspešno je zapamćen ugovor!");
				return true;
			}
		}

		internal bool obrisiRadnika()
		{
			DialogResult dialog = MessageBox.Show("Da li ste sigurni da želite da obrišete radnika?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			switch (dialog)
			{

				case DialogResult.Yes:
					Object rez = komunikacija.obrisiRadnika(radnik);

					if (rez == null)
					{
						MessageBox.Show("Sistem ne može da obriše radnika!");
						return false;
					}
					else
					{
						MessageBox.Show("Sistem je uspešno obrisao radnika!");
						return true;
					}
			}
			return false;
		}

		public void kraj()
		{
			try
			{
				komunikacija.kraj();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		internal bool pronadjiZaposlenog(TextBox txtKorisnickoIme, TextBox txtKorisnickaSifra)
		{
			zaposleni = new Zaposleni();
			zaposleni.KorisnickoIme = txtKorisnickoIme.Text;
			zaposleni.KorisnickaSifra = txtKorisnickaSifra.Text;

			zaposleni.Uslovi = " KorisnickoIme='" + zaposleni.KorisnickoIme + "' and KorisnickaSifra='" + zaposleni.KorisnickaSifra + "'";

			zaposleni = komunikacija.PronadjiZaposlenog(zaposleni) as Zaposleni;

			if (zaposleni == null)
			{
				MessageBox.Show("Sistem ne moze da pronađe zaposlenog!");
				return false;
			}
			else
			{
				MessageBox.Show("Uspešno ste se prijavili na sistem!");
				return true;
			}
		}

		internal bool ucitajRadnika(DataGridView dgvPretraga)
		{
			try
			{
				radnik = dgvPretraga.CurrentRow.DataBoundItem as Radnik;

				radnik = komunikacija.ucitajRadnika(radnik) as Radnik;

				if (radnik == null)
				{
					MessageBox.Show("Sistem ne može da učita podatke o izabranom radniku!");
					return false;
				}
				else
				{
					MessageBox.Show("Sistem je uspešno učitao podatke o izabranom radniku!");
					return true;
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Niste odabrali radnika!");
				return false;
			}
		}

		internal void ucitajListuMesta(ComboBox cmbMesto)
		{
			cmbMesto.DataSource = komunikacija.ucitajSvaMesta();
		}

		internal void ucitajListuKvalifikacija(ComboBox cmbKvalifikacije)
		{
			cmbKvalifikacije.DataSource = komunikacija.ucitajSveKvalifikacije();
		}

		internal bool zapamtiRadnika(ComboBox cmbKvalifikacije, ComboBox cmbMesto, TextBox txtImeRadnika, TextBox txtPrezimeRadnika, TextBox txtJMBG, TextBox txtUlica, CheckBox cbMuski, CheckBox cbZenski)
		{
			radnik = new Radnik();
			radnik.Kvalifikacije = cmbKvalifikacije.SelectedItem as Kvalifikacije;
			radnik.Mestoo = cmbMesto.SelectedItem as Mesto;


			if (cbMuski.Checked == true)
			{
				radnik.Pol = cbMuski.Text;
			}
			else
			{
				radnik.Pol = cbZenski.Text;
			}

			if (cbMuski.Checked == false && cbZenski.Checked == false)
			{
				MessageBox.Show("Niste odabrali pol!");
				return false;
			}

			if (cmbKvalifikacije.Text == "Izaberite kvalifikacije!")
			{
				MessageBox.Show("Niste odabrali kvalifikacije!");
				return false;
			}

			if (cmbMesto.Text == "Izaberite mesto!")
			{
				MessageBox.Show("Niste odabrali mesto!");
				return false;
			}

			radnik.Ime = txtImeRadnika.Text;
			radnik.Prezime = txtPrezimeRadnika.Text;
			radnik.Ulica = txtUlica.Text;
			radnik.Jmbg = txtJMBG.Text;

			if (radnik.Ime == "")
			{
				MessageBox.Show("Morate uneti ime radnika!");
				txtImeRadnika.Focus();
				return false;
			}

			if (radnik.Prezime == "")
			{
				MessageBox.Show("Morate uneti prezime radnika!");
				txtPrezimeRadnika.Focus();
				return false;
			}

			if (radnik.Ulica == "")
			{
				MessageBox.Show("Morate uneti ulicu za radnika!");
				txtUlica.Focus();
				return false;
			}

			if (radnik.Jmbg == "")
			{
				MessageBox.Show("Morate uneti JMBG za radnika!");
				txtJMBG.Focus();
				return false;
			}

			if (radnik.Jmbg.Length != 13)
			{
				MessageBox.Show("JMBG Radnika mora imati 13 cifara");
				txtJMBG.Focus();
				return false;
			}

			Object rez = komunikacija.zapamtiRadnika(radnik);

			if (rez == null)
			{
				MessageBox.Show("Sistem ne može da zapamti radnika!");
				return false;
			}

			else
			{
				MessageBox.Show("Sistem je uspešno zapamtio radnika!");
				return true;
			}
		}

		internal void pretraziRadnike(TextBox txtPretraga, DataGridView dgvPretragaRadnika)
		{
			radnik = new Radnik();
			radnik.uslovi = " ImeRadnika like '" + txtPretraga.Text + "%' or PrezimeRadnika like '" + txtPretraga.Text + "%' or Ulica like '" + txtPretraga.Text + "%'"; ;

			List<Radnik> lista = komunikacija.pretraziRadnike(radnik) as List<Radnik>;

			dgvPretragaRadnika.DataSource = lista;
			dgvPretragaRadnika.Columns[3].Width = 70;

			if (lista == null)
			{
				MessageBox.Show("Sistem ne može da pronađe radnike!");
				return;
			}

			if (lista.Count == 0)
			{
				MessageBox.Show("Sistem ne može da nađe podatke o radnicima po zadatim vrednostima!");
				return;
			}

			//else
			//{
			//	MessageBox.Show("Sistem je pronašao podatke o radnicima po zadatim vrednostima!");
			//	return;
			//}
		}

		internal void pretraziOJiRM(TextBox txtPretraga, DataGridView dgvPretraga)
		{

			string uslov = txtPretraga.Text;
			List<RadnoMesto> lista = komunikacija.vratiOJZaUslov(uslov) as List<RadnoMesto>;

			dgvPretraga.DataSource = lista;

			if (lista == null)
			{
				MessageBox.Show("Sistem ne može da pronađe radna mesta i organizacione jedinice!");
				return;
			}

			if (lista.Count == 0)
			{
				MessageBox.Show("Sistem ne može da nađe podatke o radnim mestima i organizacionim jedinicama po zadatim vrednostima!");
				return;
			}
		}
	}
}
