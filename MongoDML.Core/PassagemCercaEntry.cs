using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDML.Core
{
    public class PassagemCercaEntry
    {
        public const string TIPO_ENTRADA = "E";
        public const string TIPO_SAIDA = "S";

        /// <summary>
        /// Id da cerca no SGO
        /// </summary>
        public long _id { get; set; }
        /// <summary>
        /// Nome/Descrição da cerca no SGO
        /// </summary>
        public string d { get; set; }
        /// <summary>
        /// Tipo da Cerca no SGO
        /// </summary>
        public string tc { get; set; }
        /// <summary>
        /// Tipo de Evento de passagem (Entrada ou Saída)
        /// </summary>
        public string te { get; set; }
        /// <summary>
        /// Apelido da Cerca eletronica
        /// </summary>
        public string ap { get; set; }
        /// <summary>
        /// Número do poligno da cerca
        /// </summary>
        public int? pl { get; set; }
    }
}
