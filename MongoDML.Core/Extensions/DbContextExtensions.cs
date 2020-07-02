using System;
using System.Collections.Generic;
using System.Data;

namespace MongoDML.Core.Extensions
{
    public static class DbContextExtensions
    {
        public static List<T> ConvertIn<T>(this IDbCommand cmd, Func<IDataReader, T> func)
        {
            var result = new List<T>();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = func(reader);
                result.Add(item);
            }
            return result;
        }

        public static string GetStringNullable(this IDataReader reader, int i)
        {
            return reader.GetValue(i) == DBNull.Value ? null : reader.GetString(i);
        }
    }
}
