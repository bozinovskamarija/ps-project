using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOZaposleni
{
	public class PronadjiZaposlenog : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Broker.dajSesiju().vratiJedanZaOpstiUslov(odo) as Zaposleni;
		}
	}
}
