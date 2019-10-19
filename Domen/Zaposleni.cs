using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
	[Serializable]
	public class Zaposleni : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return ime + " " + prezime;
		}

		int id;
		string ime;
		string prezime;
		string korisnickoIme;
		string korisnickaSifra;

		public int Id { get => id; set => id = value; }
		public string Ime { get => ime; set => ime = value; }
		public string Prezime { get => prezime; set => prezime = value; }
		public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
		public string KorisnickaSifra { get => korisnickaSifra; set => korisnickaSifra = value; }

		#region OpstiDomenskiObjekat

		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "Zaposleni";
			}
		}

		public string Uslovi;
		[Browsable(false)]
		public string UslovOpsti
		{
			get
			{
				return Uslovi;
			}
		}

		[Browsable(false)]
		public string ID
		{
			get
			{
				return "ZaposleniID";
			}
		}



		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(ZaposleniID) values (" + ID + ")";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "ZaposleniID=" + ID;
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return "ZaposleniID=" + ID + ",Ime='" + Ime + "', Prezime='" + Prezime + "',KorisnickoIme='"+KorisnickoIme+"',KorisnickaSifra='"+KorisnickaSifra+"'";
			}
		}


		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			Zaposleni z = new Zaposleni();
			z.Id = Convert.ToInt32(red["ZaposleniID"]);
			z.Ime = red["Ime"].ToString();
			z.Prezime = red["Prezime"].ToString();

			z.KorisnickoIme = red["KorisnickoIme"].ToString();
			z.KorisnickaSifra = red["KorisnickaSifra"].ToString();
			return z;
		}
		#endregion
	}
}
