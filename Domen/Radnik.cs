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
	public class Radnik : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return ime + " " + prezime;
		}

		int sifra;
		string ime;
		string prezime;
		string jmbg;
		string pol;
		string ulica;
		Kvalifikacije kvalifikacije;
		Mesto mestoo;

		[Browsable(false)]
		public int Sifra { get => sifra; set => sifra = value; }
		public string Ime { get => ime; set => ime = value; }
		public string Prezime { get => prezime; set => prezime = value; }
		public string Jmbg { get => jmbg; set => jmbg = value; }
		public string Pol { get => pol; set => pol = value; }
		public string Ulica { get => ulica; set => ulica = value; }

		[Browsable(false)]
		public Kvalifikacije Kvalifikacije { get => kvalifikacije; set => this.kvalifikacije = value; }
		[Browsable(false)]
		public Mesto Mestoo
		{
			get => mestoo;
			set => mestoo = value;
		}	

		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "Radnik";
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
				return "SifraRadnika";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "SifraRadnika=" + Sifra;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(" + Sifra + ",'" + Ime + "','" + Prezime + "','" + Jmbg + "','" + Pol + "','" + Ulica + "'," + Kvalifikacije.KvalifikacijeID + ", " + Mestoo.Ptt + ")";
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return " ImeRadnika='" + Ime + "', PrezimeRadnika='" + Prezime + "', JMBG='" + Jmbg + "', Pol='" + Pol + "', Ulica='" + Ulica + "', KvalifikacijeID=" + Kvalifikacije.KvalifikacijeID + ", Ptt=" + Mestoo.Ptt;
			}
		}

	
		[Browsable(false)]
		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			Radnik r = new Radnik();
			r.Sifra = Convert.ToInt32(red["SifraRadnika"]);
			r.Ime = red["ImeRadnika"].ToString();
			r.Prezime = red["PrezimeRadnika"].ToString();
			r.Jmbg = red["JMBG"].ToString();
			r.Pol = red["Pol"].ToString();
			r.Ulica = red["Ulica"].ToString();

			r.Kvalifikacije = new Kvalifikacije();
			r.Kvalifikacije.KvalifikacijeID = Convert.ToInt32(red["KvalifikacijeID"]);


			r.Mestoo = new Mesto();
			r.Mestoo.Ptt = Convert.ToInt32(red["Ptt"]);
			
			return r;
		}
		#endregion ODO
	}
}
