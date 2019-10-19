using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace Server.SistemskeOperacije.SOOrganizacionaJedinica
{
	public class UcitajSvaRadnaMestaZaOJ : OpstaSistemskaOperacija
	{
		public override object Izvrsi(OpstiDomenskiObjekat odo)
		{
			RadnoMesto rm = new RadnoMesto()
			{
				Oj = odo as OrganizacionaJedinica
			};
			rm.uslovi = "SifraOJ = " + rm.Oj.SifraOJ;
			List<RadnoMesto> rmesta = Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(rm).OfType<RadnoMesto>().ToList<RadnoMesto>();
			foreach (RadnoMesto r in rmesta)
			{
				r.Radnik = Broker.dajSesiju().vratiJedanZaID(r.Radnik) as Radnik;
			}
			return rmesta;
		}
	}
}
