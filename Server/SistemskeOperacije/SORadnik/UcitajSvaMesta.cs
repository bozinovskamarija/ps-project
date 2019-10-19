using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SORadnik
{
	public class UcitajSvaMesta : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Mesto m = new Mesto();
			m.Uslovi= " Mesto je null";
			List<Mesto> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Mesto>().ToList<Mesto>();
			
			return lista;
		}
	}
}
