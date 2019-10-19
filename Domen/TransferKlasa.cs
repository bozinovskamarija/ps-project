using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
	public enum Operacije { Kraj = 1,
		PronadjiZaposlenog = 2,
		UcitajSvaMesta = 3,
		UcitajSveKvalifikacije = 4,
		ZapamtiRadnika = 5,
		PretraziRadnike = 6,
		UcitajRadnika = 7,
		ObrisiRadnika = 8,
		UcitajListuRadnika = 9,
		UcitajListuRadnihMesta = 10,
		ZapamtiUgovor = 11,
		KreirajOJ = 12,
		ZapamtiOJ = 13,
		AzurirajRadnika = 14,
		VratiUgovoreZaUslov = 15,
		PretraziOJiRM = 16,
		VratiOJZaUslov = 17,
		PronadjiOJiRM = 18,
		ObrisiOJiRM = 19,
		UcitajSvaRadnaMestaZaOJ = 20,
		ObrisiRM = 21,
	}

	[Serializable]
    public class TransferKlasa
    {
		public Operacije Operacija;
		public Object TransferObjekat; 
		public Object Rezultat; 
    }
}
