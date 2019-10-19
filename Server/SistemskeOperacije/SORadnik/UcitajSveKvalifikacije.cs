using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SORadnik
{
	public class UcitajSveKvalifikacije : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Kvalifikacije k = new Kvalifikacije();
			k.Uslovi = " Kvalifikacije su null";
			List<Kvalifikacije> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Kvalifikacije>().ToList<Kvalifikacije>();

			return lista;
		}
	}
}
