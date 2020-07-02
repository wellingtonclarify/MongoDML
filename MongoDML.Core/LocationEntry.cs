using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDML.Core
{
    public class LocationEntry
    {
        public const string TYPE_POINT = "Point";
        /// <summary>
        /// Tipo location (Point)
        /// </summary>
        public string t { get; set; } = TYPE_POINT;
        /// <summary>
        /// Coordenadas
        /// </summary>
        public double[] c { get; set; }
    }
}
