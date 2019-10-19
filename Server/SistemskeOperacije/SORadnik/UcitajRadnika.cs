using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SORadnik
{
	public class UcitajRadnika : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			Radnik r = odo as Radnik;
			
				r.Kvalifikacije = (Kvalifikacije) Broker.dajSesiju().vratiJedanZaID(r.Kvalifikacije);
				r.Mestoo = Broker.dajSesiju().vratiJedanZaID(r.Mestoo) as Mesto;
			return r;
		}
	}
}
