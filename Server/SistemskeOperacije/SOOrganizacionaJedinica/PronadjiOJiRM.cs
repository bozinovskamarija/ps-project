using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOOrganizacionaJedinica
{
	public class PronadjiOJiRM : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			RadnoMesto rm = odo as RadnoMesto;

				rm.Radnik = (Radnik)Broker.dajSesiju().vratiJedanZaID(rm.Radnik);
				rm.Kvalifikacije = (Kvalifikacije)Broker.dajSesiju().vratiJedanZaID(rm.Kvalifikacije);
				rm.Oj = (OrganizacionaJedinica)Broker.dajSesiju().vratiJedanZaID(rm.Oj);

			return rm;
		}
	}
}
