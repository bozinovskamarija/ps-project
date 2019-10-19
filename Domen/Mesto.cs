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
	public class Mesto : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return ptt + " " + naziv;
		}

		int ptt;
		string naziv;

		public int Ptt { get => ptt; set => ptt = value; }
		public string Naziv { get => naziv; set => naziv = value; }

		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "Mesto";
			}
		}

		public string Uslovi;

		public string UslovOpsti
		{
			get
			{
				return Uslovi;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(Ptt) values (" + Ptt + ")";
			}
		}

		[Browsable(false)]
		public string ID
		{
			get
			{
				return "Ptt";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "Ptt=" + Ptt;
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return "Ptt=" + Ptt + ",Naziv='" + Naziv + "'";
			}
		}
		

		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			Mesto m = new Mesto();
			m.Ptt = Convert.ToInt32(red["Ptt"]);
			m.Naziv = red["Naziv"].ToString();
			return m;
		}


		#endregion ODO
	}
}
