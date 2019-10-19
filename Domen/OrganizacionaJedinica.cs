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
	public class OrganizacionaJedinica : OpstiDomenskiObjekat
	{
		public override string ToString()
		{
			return Naziv;
		}
		
		int sifraOJ;
		string naziv;
		BindingList<RadnoMesto> listaRadnihMesta;

		public OrganizacionaJedinica()
		{
			listaRadnihMesta = new BindingList<RadnoMesto>();
		}
		
		[Browsable(false)]
		public int SifraOJ { get => sifraOJ; set => sifraOJ = value; }
		public string Naziv { get => naziv; set => naziv = value; }
		public BindingList<RadnoMesto> ListaRadnihMesta { get => listaRadnihMesta; set => listaRadnihMesta = value; }

		#region ODO
		[Browsable(false)]
		public string NazivTabele
		{
			get
			{
				return "OrganizacionaJedinica";
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
				return "SifraOJ";
			}
		}

		[Browsable(false)]
		public string UslovID
		{
			get
			{
				return "SifraOJ=" + SifraOJ;
			}
		}

		[Browsable(false)]
		public string Insert
		{
			get
			{
				return "(" + SifraOJ + ",'" + Naziv + "')";
			}
		}

		[Browsable(false)]
		public string Update
		{
			get
			{
				return "SifraOJ=" + SifraOJ+ ",NazivOJ='" + Naziv + "'";
			}
		}
		public OpstiDomenskiObjekat procitajRed(DataRow red)
		{
			OrganizacionaJedinica oj = new OrganizacionaJedinica();
			oj.SifraOJ = Convert.ToInt32(red["SifraOJ"]);
			oj.Naziv= red["NazivOJ"].ToString();
			return oj;
		}

		#endregion ODO
	}
}
