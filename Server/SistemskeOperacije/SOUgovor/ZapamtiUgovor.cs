using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOUgovor
{
	public class ZapamtiUgovor : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			UgovorORadu ugovor = (UgovorORadu) odo;
			ugovor.UgovorId = Broker.dajSesiju().vratiSifru(odo);
			return Broker.dajSesiju().insert(odo);
		}
	}
}
