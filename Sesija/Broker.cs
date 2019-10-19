using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Sesija
{
	public class Broker
	{
		SqlCommand komanda;
		SqlConnection konekcija;
		SqlTransaction transakcija;
		SqlDataReader citac;

		static Broker instanca;
		public static Broker dajSesiju()
		{
			if (instanca == null) instanca = new Broker();
			return instanca;
		}

		public void otvoriKonekciju()
		{
			try
			{
				//konekcija = new SqlConnection(@"Data Source=MACAHP\SQLEXPRESS;Initial Catalog=MNDJ;Integrated Security=True");
				string prom = ConfigurationManager.AppSettings["kljuc"];
				konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString);

				konekcija.Open();
			}
			catch (Exception)
			{

				MessageBox.Show("Ne može da se uspostavi konekcija na bazu!");
				throw;
			}
		}

		public void zapocniTransakciju()
		{
			try
			{
				transakcija = konekcija.BeginTransaction();
				komanda = new SqlCommand("", konekcija, transakcija);
			}
			catch (Exception)
			{

				MessageBox.Show("Ne može da se uspostavi transakcija na bazi!");
				throw;
			}
		}

		public void potvrdiTransakciju()
		{
			try
			{
				transakcija.Commit();
			}
			catch (Exception)
			{

				MessageBox.Show("Sistem ne može da potvrdi transakciju!");
				throw;
			}
		}

		public void ponistiTransakciju()
		{
			try
			{
				transakcija.Rollback();
			}
			catch (Exception)
			{

				MessageBox.Show("Sistem ne može da poništi transakciju!");
				throw;
			}
		}

		public void zatvoriKonekciju()
		{
			try
			{
				konekcija.Close();
			}
			catch (Exception)
			{

				MessageBox.Show("Sistem ne može da zatvori konekciju!");
				throw;
			}
		}

		public OpstiDomenskiObjekat vratiJedanZaOpstiUslov(OpstiDomenskiObjekat odo)
		{

			try
			{
				komanda.CommandText = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
				citac = komanda.ExecuteReader();
				DataTable tabela = new DataTable();
				tabela.Load(citac);
				citac.Close();
				if (tabela.Rows.Count == 0)
				{
					return null;
				}
				else return odo.procitajRed(tabela.Rows[0]);

			}
			catch (Exception)
			{
				citac.Close();
				throw;
			}
		}

		public List<OpstiDomenskiObjekat> vratiSveZaUslovOpsti(OpstiDomenskiObjekat odo)
		{
			try
			{
				komanda.CommandText = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovOpsti;
				citac = komanda.ExecuteReader();
				DataTable tabela = new DataTable();
				tabela.Load(citac);
				List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

				foreach (DataRow red in tabela.Rows)
				{
					lista.Add(odo.procitajRed(red));
				}

				return lista;
			}
			catch (Exception e)
			{
				citac.Close();
				throw;
			}
			finally
			{
				if (citac != null)
				{
					citac.Close();
				}
			}
		}

		public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
		{
			List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
			try
			{
				komanda.CommandText = "SELECT * FROM " + odo.NazivTabele;
				citac = komanda.ExecuteReader();
				DataTable tabela = new DataTable();
				tabela.Load(citac);
				foreach (DataRow red in tabela.Rows)
				{
					lista.Add(odo.procitajRed(red));
				}
				citac.Close();
				return lista;
			}
			catch (Exception)
			{
				citac.Close();
				throw;
			}
		}

		public int vratiSifru(OpstiDomenskiObjekat odo)
		{
			try
			{
				string upit = "SELECT MAX(" + odo.ID + ") FROM " + odo.NazivTabele;
				SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
				try
				{
					return Convert.ToInt32(komanda.ExecuteScalar()) + 1;
				}
				catch (Exception ex)
				{
					return 1;
				}
			}
			catch (Exception)
			{
				throw new Exception("Greška");
			}
		}

		public int insert(OpstiDomenskiObjekat odo)
		{

			string upit = "INSERT INTO " + odo.NazivTabele + " VALUES " + odo.Insert;
			SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
			try
			{
				return komanda.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception("Greška");
			}
		}

		public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
		{

			try
			{
				komanda.CommandText = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
				citac = komanda.ExecuteReader();
				DataTable tabela = new DataTable();
				tabela.Load(citac);
				citac.Close();
				if (tabela.Rows.Count == 0)
				{
					return null;
				}
				else return odo.procitajRed(tabela.Rows[0]);

			}
			catch (Exception)
			{
				citac.Close();
				throw;
			}
		}

		public int update(OpstiDomenskiObjekat odo)
		{

			komanda.CommandText = "UPDATE " + odo.NazivTabele + " SET " + odo.Update + " WHERE " + odo.UslovID;

			try
			{
				return komanda.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception("Greska u radu sa bazom!");
			}
		}

		public int deleteJedan(OpstiDomenskiObjekat odo)
		{

			komanda.CommandText = "DELETE FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;

			try
			{
				return komanda.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw new Exception("Greška!");
			}
		}


		public List<UgovorORadu> vratiUgovoreZaUslov(string uslov)
		{
			List<UgovorORadu> lista = new List<UgovorORadu>();
			try
			{
				konekcija.Open();
				komanda.CommandText = "Select * from UgovorORadu uor inner join RadnoMesto rm on uor.SifraRM=rm.SifraRM inner join  Radnik r on uor.SifraRadnika=r.SifraRadnika  where rm.NazivRM like '" + uslov + "%' or r.ImeRadnika like'" + uslov + "%' or r.PrezimeRadnika like '" + uslov +"%' or uor.TipUgovora like'"+uslov +"%'";
				SqlDataReader citac = komanda.ExecuteReader();
				while (citac.Read())
				{
					UgovorORadu uor = new UgovorORadu();
					uor.DatumSklapanja = citac.GetDateTime(1);
					uor.DatumUkidanja= citac.GetDateTime(2);
					uor.TipUgovora = citac.GetString(3);
					uor.Radnik = new Radnik();
					uor.Radnik.Sifra = citac.GetInt32(12);
					uor.Radnik.Ime = citac["ImeRadnika"].ToString();
					uor.Radnik.Prezime = citac["PrezimeRadnika"].ToString();

					uor.Rm = new RadnoMesto();
					uor.Rm.Sifra = citac.GetInt32(8);
					//uor.Rm.SifraOJ = citac.GetInt32(9);
					uor.Oj = new OrganizacionaJedinica();
					uor.Oj.SifraOJ = citac.GetInt32(9);
					uor.Rm.Naziv = citac.GetString(10);
					uor.Rm.Kvalifikacije = new Kvalifikacije();
					uor.Rm.Kvalifikacije.KvalifikacijeID = citac.GetInt32(11);

					lista.Add(uor);
				}
				citac.Close();
				return lista;
			}
			catch (Exception e)
			{
				return null;
			}
			finally { if (konekcija != null) konekcija.Close(); }
		}


		public List<RadnoMesto> vratiOJZaUslov(string uslov)
		{
			List<RadnoMesto> lista = new List<RadnoMesto>();
			try
			{
				konekcija.Open();
				komanda.CommandText = "SELECT * FROM RadnoMesto rm INNER JOIN OrganizacionaJedinica oj ON rm.SifraOJ=oj.SifraOJ INNER JOIN Radnik r ON rm.SifraRadnika=r.SifraRadnika  where rm.NazivRM like '" + uslov + "%' or oj.NazivOJ like'" + uslov +"%' or r.ImeRadnika like'"+uslov+"%' or r.PrezimeRadnika like'"+uslov+ "%'";
				SqlDataReader citac = komanda.ExecuteReader();
				while (citac.Read())
				{
					RadnoMesto rm = new RadnoMesto();
					rm.Sifra = citac.GetInt32(0);
					rm.Oj = new OrganizacionaJedinica();
					rm.Oj.SifraOJ = citac.GetInt32(1);
					rm.Naziv = citac.GetString(2);
					rm.Kvalifikacije = new Kvalifikacije();
					rm.Kvalifikacije.KvalifikacijeID = citac.GetInt32(3);

					rm.Radnik = new Radnik();
					rm.Radnik.Sifra = citac.GetInt32(4);

					rm.Oj = new OrganizacionaJedinica();
					rm.Oj.SifraOJ = citac.GetInt32(5);
					rm.Oj.Naziv = citac.GetString(6);

					rm.Radnik = new Radnik();
					rm.Radnik.Sifra = citac.GetInt32(7);
					rm.Radnik.Ime = citac.GetString(8);
					rm.Radnik.Prezime = citac.GetString(9);
					rm.Radnik.Jmbg = citac.GetString(10);
					rm.Radnik.Pol = citac.GetString(11);
					rm.Radnik.Ulica = citac.GetString(12);
					rm.Kvalifikacije = new Kvalifikacije();
					rm.Kvalifikacije.KvalifikacijeID = citac.GetInt32(13);
					
					lista.Add(rm);
				}
				citac.Close();
				return lista;
			}
			catch (Exception e)
			{

				return null;
			}
			finally { if (konekcija != null) konekcija.Close(); }
		}
	}
}

