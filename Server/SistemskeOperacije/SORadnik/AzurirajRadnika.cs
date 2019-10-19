using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SORadnik
{
	public class AzurirajRadnika : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			return Broker.dajSesiju().update(odo);
		}
	}
}
