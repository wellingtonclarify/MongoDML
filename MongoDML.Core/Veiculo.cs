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
    public class Veiculo : BaseDbEntity
    {
        public string Prefixo { get; set; }
        public string Placa { get; set; }
        public string IdentificacaoGPS { get; set; }
        public long UnidadeId { get; set; }

        public static List<Veiculo> GetAll()
        {
            var result = new List<Veiculo>();
            using (var conn = DbConnectionFactory.GetInstance())
            {
                var query = @"select v.Id, v.Prefixo, v.Placa, v.IdentificacaoGPS, r.UnidadeId from Veiculo v join Recurso r on r.Id = v.Id where r.Ativo = 1 order by v.prefixo";
                var cmd = DbCommand.GetInstance(query, conn);
                result = cmd.ConvertIn(GetAllConverter);
            }
            return result;
        }

        private static Veiculo GetAllConverter(IDataReader reader)
        {
            var result = new Veiculo()
            {
                Id = reader.GetInt64(0),
                Prefixo = reader.GetString(1),
                Placa = reader.GetString(2),
                IdentificacaoGPS = reader.GetStringNullable(3),
                UnidadeId = reader.GetInt64(4)
            };
            return result;
        }
    }
}
