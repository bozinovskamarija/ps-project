using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domen;

using Server.SistemskeOperacije.SOZaposleni;
using Server.SistemskeOperacije.SORadnik;
using Server.SistemskeOperacije.SOUgovor;
using Server.SistemskeOperacije.SOOrganizacionaJedinica;
using Sesija;

namespace Server
{
	class NitKlijenta
	{
		private NetworkStream tok;
		BinaryFormatter formater;

		public NitKlijenta(NetworkStream tok)
		{
			this.tok = tok;
			formater = new BinaryFormatter();

			ThreadStart nitDelegat = obradiZahtev;
			new Thread(nitDelegat).Start();
		}

		void obradiZahtev()
		{
			try
			{
				int operacija = 0;
				while (operacija != (int)Operacije.Kraj)
				{

					TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

					switch (transfer.Operacija)
					{
						case Operacije.PronadjiZaposlenog:
							PronadjiZaposlenog zaposleni = new PronadjiZaposlenog();
							transfer.Rezultat = zaposleni.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajSvaMesta:
							UcitajSvaMesta usm = new UcitajSvaMesta();
							transfer.Rezultat = usm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajSveKvalifikacije:
							UcitajSveKvalifikacije usk = new UcitajSveKvalifikacije();
							transfer.Rezultat = usk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.ZapamtiRadnika:
							ZapamtiRadnika zr = new ZapamtiRadnika();
							transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.AzurirajRadnika:
							AzurirajRadnika ar = new AzurirajRadnika();
							transfer.Rezultat = ar.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.PretraziRadnike:
							PretraziRadnike pr = new PretraziRadnike();
							transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajRadnika:
							UcitajRadnika ur = new UcitajRadnika();
							transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.ObrisiRadnika:
							ObrisiRadnika or = new ObrisiRadnika();
							transfer.Rezultat = or.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajListuRadnihMesta:
							UcitajListuRM ulrm = new UcitajListuRM();
							transfer.Rezultat = ulrm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajListuRadnika:
							UcitajListuRadnika ulr = new UcitajListuRadnika();
							transfer.Rezultat = ulr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						
						case Operacije.ZapamtiUgovor:
							ZapamtiUgovor zu = new ZapamtiUgovor();
							transfer.Rezultat = zu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.VratiUgovoreZaUslov:
							transfer.Rezultat = Broker.dajSesiju().vratiUgovoreZaUslov(transfer.TransferObjekat as string);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.KreirajOJ:
							KreirajOJ koj = new KreirajOJ();
							transfer.Rezultat = koj.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.ZapamtiOJ:
							ZapamtiOJ zoj = new ZapamtiOJ();
							transfer.Rezultat = zoj.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.VratiOJZaUslov:
							transfer.Rezultat = Broker.dajSesiju().vratiOJZaUslov(transfer.TransferObjekat as string);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.PronadjiOJiRM:
							PronadjiOJiRM projrm = new PronadjiOJiRM();
							transfer.Rezultat = projrm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.ObrisiOJiRM:
							ObrisiOJiRM oojrm = new ObrisiOJiRM();
							transfer.Rezultat = oojrm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.ObrisiRM:
							ObrisiRM orm = new ObrisiRM();
							transfer.Rezultat = orm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.UcitajSvaRadnaMestaZaOJ:
							UcitajSvaRadnaMestaZaOJ usrmoj = new UcitajSvaRadnaMestaZaOJ();
							transfer.Rezultat = usrmoj.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
							formater.Serialize(tok, transfer);
							break;
						case Operacije.Kraj:
							operacija = 1;							Server.listaTokovaKlijenata.Remove(tok);
							break;
						default:
							break;
					}
				}
			}

			catch (Exception)
			{
				try
				{
					Server.listaTokovaKlijenata.Remove(tok);
				}
				catch (Exception)
				{

				}
			}
		}
	}
}
