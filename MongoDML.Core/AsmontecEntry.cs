using MongoDB.Bson;
using System;

namespace MongoDML.Core
{
    public class AsmontecEntry
    {
		public ObjectId _id { get; set; }
		/*DeviceId - Veículo*/
		public string tid { get; set; }

		public int sp { get; set; }
		public int d { get; set; }
		public int alt { get; set; }

		/* Hora do Evento */
		public DateTime tm { get; set; }
		/* Hora da Recepção no servidor */
		public DateTime stm { get; set; }
		public double[] gps { get; set; }
	}
}
