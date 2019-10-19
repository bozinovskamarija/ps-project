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
	public class Kvalifikacije : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return struka;
		}
		int kvalifikacijeID;
		int sss;
		string struka;

		public int KvalifikacijeID { get => kvalifikacijeID; set => kvalifikacijeID = value; }
		public int Sss { get => sss; set => sss = value; }
		public string Struka { get => struka; set => struka = value; }


		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "Kvalifikacije";
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
		public string ID
		{
			get
			{
				return "KvalifikacijeID";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "KvalifikacijeID=" + KvalifikacijeID;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(KvalifikacijeID) values (" + kvalifikacijeID + ")";
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return "KvalifikacijeID=" + KvalifikacijeID + ",SSS=" + Sss +",Struka='"+Struka+ "'";
			}
		}
		

		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			Kvalifikacije k = new Kvalifikacije();
			k.KvalifikacijeID = Convert.ToInt32(red["KvalifikacijeID"]);
			k.Sss = Convert.ToInt32(red["SSS"]);
			k.Struka = red["Struka"].ToString();
			return k;
		}

		#endregion ODO


	}
}
