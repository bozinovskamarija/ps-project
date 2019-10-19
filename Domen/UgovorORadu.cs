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
	public class UgovorORadu : OpstiDomenskiObjekat
	{
		int ugovorId;
		DateTime datumSklapanja;
		DateTime datumUkidanja;
		string tipUgovora;
		string napomena;
		OrganizacionaJedinica oj;
		RadnoMesto rm;
		Radnik radnik;

		[Browsable(false)]
		public int UgovorId { get => ugovorId; set => ugovorId = value; }
		[Browsable(false)]
		public Radnik Radnik { get => radnik; set => radnik = value; }
		[DisplayName("Radnik")]
		public string Radnik1
		{
			get
			{
				return radnik.Ime +" "+radnik.Prezime;
			}
			set
			{
				radnik.Ime = value;
				radnik.Prezime = value;
			}
		}

		[DisplayName("Radno mesto")]
		public string RadnoMesto1
		{
			get
			{
				return rm.Naziv ;
			}
			set
			{
				rm.Naziv = value;
			}
		}
		public DateTime DatumSklapanja { get => datumSklapanja; set => datumSklapanja = value; }
		public DateTime DatumUkidanja { get => datumUkidanja; set => datumUkidanja = value; }
		public string TipUgovora { get => tipUgovora; set => tipUgovora = value; }
		[Browsable(false)]
		public string Napomena { get => napomena; set => napomena = value; }
		[Browsable(false)]
		public OrganizacionaJedinica Oj { get => oj; set => oj = value; }
		[Browsable(false)]
		public RadnoMesto Rm { get => rm; set => rm = value; }

		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "UgovorORadu";
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
				return "UgovorID";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "UgovorID=" + UgovorId;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(" + UgovorId + ",'" + DatumSklapanja.ToString() + "','" + DatumUkidanja.ToString() + "','" + TipUgovora + "','" + Napomena + "'," + Radnik.Sifra + "," + rm.Sifra + "," + oj.SifraOJ + ")";
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return " DatumSklapanja='" + datumSklapanja.ToString() + "', DatumUkidanja='" + datumUkidanja.ToString() + "', TipUgovora='" + tipUgovora + "',Napomena=" + Napomena + "', SifraRadnika=" + radnik.Sifra + ", SifraRM=" + rm.Sifra + ", SifraOJ=" + oj.SifraOJ + "";
			}
		}

		[Browsable(false)]
		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			UgovorORadu uor = new UgovorORadu();
			uor.UgovorId = Convert.ToInt32(red["UgovorID"]);

			uor.datumSklapanja = Convert.ToDateTime(red["DatumSklapanja"]);
			uor.datumUkidanja = Convert.ToDateTime(red["DatumUkidanja"]);


			uor.TipUgovora = red["TipUgovora"].ToString();
			uor.Napomena = red["Napomena"].ToString();


			uor.Radnik = new Radnik();
			uor.Radnik.Sifra = Convert.ToInt32(red["SifraRadnika"]);


			uor.rm = new RadnoMesto();
			uor.rm.Sifra = Convert.ToInt32(red["SifraRM"]);

			uor.oj = new OrganizacionaJedinica();
			uor.oj.SifraOJ = Convert.ToInt32(red["SifraOJ"]);

			return uor;
		}

		#endregion ODO
	}
}
