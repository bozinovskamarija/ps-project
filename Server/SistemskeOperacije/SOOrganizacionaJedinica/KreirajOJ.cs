using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOOrganizacionaJedinica
{
	public class KreirajOJ : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			OrganizacionaJedinica oj = new OrganizacionaJedinica();
			oj.SifraOJ = Broker.dajSesiju().vratiSifru(odo);
			return oj;
		}
	}
}
