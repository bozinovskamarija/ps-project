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
	public class RadnoMesto : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return naziv;
		}

		int sifra;
		OrganizacionaJedinica oj;
		string naziv;
		Kvalifikacije kvalifikacije;
		Radnik radnik;

		[Browsable(false)]
		public int Sifra { get => sifra; set => sifra = value; }
		[DisplayName("Naziv radnog mesta")]
		public string Naziv { get => naziv; set => naziv = value; }
		[Browsable(false)]
		public Kvalifikacije Kvalifikacije { get => kvalifikacije; set => kvalifikacije = value; }
		[DisplayName("Kvalifikacije")]
		public int Kvalifikacije1
		{
			get
			{
				return kvalifikacije.KvalifikacijeID;
			}
			set
			{
				kvalifikacije.KvalifikacijeID = value;
			}
		}
		public Radnik Radnik { get => radnik; set => radnik = value; }

		[Browsable(false)]
		public OrganizacionaJedinica Oj { get => oj; set => oj = value; }
		[DisplayName("Naziv OJ")]
		public string NazivOJ
		{
			get
			{
				return oj.Naziv;
			}
			set
			{
				oj.Naziv = value;
			}
		}

		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "RadnoMesto";
			}
		}

		public string uslovi;
		[Browsable(false)]
		public string UslovOpsti
		{
			get
			{
				return uslovi;
			}
		}

		[Browsable(false)]
		public string ID
		{
			get
			{
				return "SifraRM";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "SifraRM=" + Sifra;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(" + Sifra + "," + oj.SifraOJ + ",'" + Naziv + "'," + Kvalifikacije.KvalifikacijeID + "," + radnik.Sifra + ")";
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return "SifraOJ=" + oj.SifraOJ + " NazivRM='" + Naziv + "', KvalifikacijeID=" + Kvalifikacije.KvalifikacijeID + ",SifraRadnika=" + radnik.Sifra + "";
			}
		}

		[Browsable(false)]
		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			RadnoMesto rm = new RadnoMesto();
			rm.Sifra = Convert.ToInt32(red["SifraRM"]);
			rm.Oj = new OrganizacionaJedinica();
			rm.Oj.SifraOJ = Convert.ToInt32(red["SifraOJ"]);

			rm.Naziv = red["NazivRM"].ToString();


			rm.Kvalifikacije = new Kvalifikacije();
			rm.Kvalifikacije.KvalifikacijeID = Convert.ToInt32(red["KvalifikacijeID"]);

			rm.Radnik = new Radnik();
			rm.Radnik.Sifra = Convert.ToInt32(red["SifraRadnika"]);

			return rm;
		}

		#endregion ODO
	}
}
