using MongoDML.Core.DbContext;
using MongoDML.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDML.Core
{
    public class Cerca : BaseDbEntity
    {
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public decimal? LatitudeGaragem { get; set; }
        public decimal? LongitudeGaragem { get; set; }

        public static List<Cerca> GetAll()
        {
            var result = new List<Cerca>();
            using (var conn = DbConnectionFactory.GetInstance())
            {
                var query = @"select c.Id, c.Descricao, t.Tipo, c.LatitudeGaragem, c.LongitudeGaragem from CercaEletronica c join CercaEletronicaTipo t on t.Id = c.TipoId where t.id in (2) and c.ativo = 1 and c.DtDelete is null order by c.Descricao";
                var cmd = DbCommand.GetInstance(query, conn);
                result = cmd.ConvertIn(GetAllConverter);
            }
            return result;
        }

        private static Cerca GetAllConverter(IDataReader reader)
        {
            var result = new Cerca()
            {
                Id = reader.GetInt64(0),
                Descricao = reader.GetString(1),
                Tipo = reader.GetString(2),
                LatitudeGaragem = reader.GetDecimalNullable(3),
                LongitudeGaragem = reader.GetDecimalNullable(4),
            };
            return result;
        }
    }
}
