using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
	public interface OpstiDomenskiObjekat
	{
		string NazivTabele { get; }
		string UslovOpsti { get;  }
		string ID { get; }
		string UslovID { get; }
		string Update { get; }
		string Insert { get; }
		

		OpstiDomenskiObjekat procitajRed(DataRow dataRow);
	}
}
