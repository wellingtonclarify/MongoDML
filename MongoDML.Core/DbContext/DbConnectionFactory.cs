using MongoDML.Core.Helpers;
using System.Configuration;
using System.Data;

namespace MongoDML.Core.DbContext
{
    public static class DbConnectionFactory
    {
        public static IDbConnection GetInstance()
        {         
            var connectionString = ConfigHelper.GetInstance().Get("dbConnectionString");
            var connection = DbConnection.GetInstance(connectionString);
            connection.Open();
            return connection;
        }
    }
}
