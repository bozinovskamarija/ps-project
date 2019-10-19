using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SORadnik
{
	public class ZapamtiRadnika : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
		   Radnik r = (Radnik) odo;
			r.Sifra = Broker.dajSesiju().vratiSifru(odo);	
			Broker.dajSesiju().insert(odo);

			return r;
		}
	}
}
