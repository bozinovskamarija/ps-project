using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SOUgovor
{
	public class UcitajListuRadnika : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Radnik r = new Radnik();
			r.uslovi = "Radnik je null";
			List<Radnik> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Radnik>().ToList<Radnik>();

			return lista;
		}
	}
}
