using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOOrganizacionaJedinica
{
	public class ZapamtiOJ : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			OrganizacionaJedinica oj = odo as OrganizacionaJedinica;
			oj.SifraOJ = Broker.dajSesiju().vratiSifru(odo);
			Broker.dajSesiju().insert(oj);

			foreach (RadnoMesto rm in oj.ListaRadnihMesta)
			{
				rm.Oj.SifraOJ= oj.SifraOJ;
				Broker.dajSesiju().insert(rm);
			}
			return true;
		}
	}
}
