using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SistemskeOperacije.SOUgovor
{
	public class UcitajListuRM : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			RadnoMesto rm = new RadnoMesto();
			rm.uslovi = " Radno mesto je null";
			List<RadnoMesto> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<RadnoMesto>().ToList<RadnoMesto>();

			return lista;
		}
	}
}
