using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDML.Core
{
    public class GPSEntry
    {
        public GPSEntry() { }

        public ObjectId _id { get; set; } = ObjectId.GenerateNewId();

        /// <summary>
        /// Prefixo
        /// </summary>
        public string v { get; set; }
        /// <summary>
        /// Data no GPS (Veículo)
        /// </summary>
        public DateTime dtg { get; set; }
        /// <summary>
        /// Data de Leitura pelo sistema de GPS
        /// </summary>
        public DateTime dtl { get; set; }
        /// <summary>
        /// Data de processamento Telemetria
        /// </summary>
        public DateTime dtp { get; set; }
        /// <summary>
        /// Location (Coordenada GPS)
        /// </summary>
        public LocationEntry l { get; set; }
        /// <summary>
        /// Velocidade
        /// </summary>
        public decimal sp { get; set; }
        /// <summary>
        /// Cercas relacionadas ao ponto
        /// </summary>
        public List<CercaEntry> cs { get; set; } = new List<CercaEntry>();
        /// <summary>
        /// Passagens de Cerca relacionadas ao ponto
        /// </summary>

        /// <summary>
        /// Alerta
        /// </summary>
        public string a { get; set; }

        public int fl { get; set; }

        /// <summary>
        /// ID GPS
        /// </summary>
        public string idg { get; set; }

        public List<PassagemCercaEntry> pcs { get; set; } = new List<PassagemCercaEntry>();
    }
}
