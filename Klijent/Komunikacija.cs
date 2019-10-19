using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Net; 
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
	public class Komunikacija
	{
		TcpClient klijent;
		BinaryFormatter formater;
		NetworkStream tok;
		
		public bool poveziSeNaServer()
		{
			try
			{
				klijent = new TcpClient("localhost", 20003);
				tok = klijent.GetStream();
				formater = new BinaryFormatter();
				return true;
			}
			catch (Exception) { return false; }
		}

		internal Object obrisiOJiRM(OrganizacionaJedinica oj)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ObrisiOJiRM;
			transfer.TransferObjekat = oj;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		public Object PronadjiZaposlenog(Zaposleni z)
		{
			try
			{
				TransferKlasa transfer = new TransferKlasa();
				transfer.Operacija = Operacije.PronadjiZaposlenog;
				transfer.TransferObjekat = z;
				formater.Serialize(tok, transfer);
				transfer = formater.Deserialize(tok) as TransferKlasa;
				return transfer.Rezultat as Zaposleni;
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Zaposleni nije pronađen!");
				return ex.Message;
			}		
		}

		internal object obrisiRMIzBaze(RadnoMesto rm)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ObrisiRM;
			transfer.TransferObjekat = rm;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object ucitajSvaRadnaMestaZaOJ(OrganizacionaJedinica oj)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajSvaRadnaMestaZaOJ;
			transfer.TransferObjekat = oj;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object pronadjiOJiRM(RadnoMesto rm)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.PronadjiOJiRM;
			transfer.TransferObjekat = rm;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object vratiUgovoreZaUslov(string uslov)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.VratiUgovoreZaUslov;
			transfer.TransferObjekat = uslov;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}


		internal object zapamtiOJ(OrganizacionaJedinica oj)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ZapamtiOJ;
			transfer.TransferObjekat = oj;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object kreirajOJ()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.KreirajOJ;
			transfer.TransferObjekat = new OrganizacionaJedinica();
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object ucitajSveRadnike()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajListuRadnika;
			transfer.TransferObjekat = new Radnik();
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object ucitajSvaRadnaMesta()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajListuRadnihMesta;
			transfer.TransferObjekat = new RadnoMesto();
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		public Object ucitajSvaMesta()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajSvaMesta;
			transfer.TransferObjekat = new Mesto();
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object azurirajRadnika(Radnik radnik)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.AzurirajRadnika;
			transfer.TransferObjekat = radnik;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		public Object ucitajSveKvalifikacije()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajSveKvalifikacije;
			transfer.TransferObjekat = new Kvalifikacije();
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object obrisiRadnika(Radnik radnik)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ObrisiRadnika;
			transfer.TransferObjekat = radnik;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object ucitajRadnika(Radnik radnik)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.UcitajRadnika;
			transfer.TransferObjekat = radnik;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal object zapamtiUgovor(UgovorORadu ugovor)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ZapamtiUgovor;
			transfer.TransferObjekat = ugovor;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		public void kraj()
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.Kraj;
			formater.Serialize(tok, transfer);
		}

		public Object zapamtiRadnika(Radnik r)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.ZapamtiRadnika;
			transfer.TransferObjekat = r;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object pretraziRadnike(Radnik radnik)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.PretraziRadnike;
			transfer.TransferObjekat = radnik;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}

		internal Object vratiOJZaUslov(string uslov)
		{
			TransferKlasa transfer = new TransferKlasa();
			transfer.Operacija = Operacije.VratiOJZaUslov;
			transfer.TransferObjekat = uslov;
			formater.Serialize(tok, transfer);

			transfer = formater.Deserialize(tok) as TransferKlasa;
			return transfer.Rezultat;
		}
	}
}
