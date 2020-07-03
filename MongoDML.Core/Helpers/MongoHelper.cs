using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDML.Core.Extensions;
using System;

namespace MongoDML.Core.Helpers
{
    public static class MongoHelper
    {
        public static IMongoClient CreateConnection(string host, int port)
        {
            var settings = new MongoClientSettings
            {
                Server = new MongoServerAddress(host, port)
            };
            var client = new MongoClient(settings);
            return client;
        }

        public static void InsertSGO(string host, int port, string database, string collection, string record)
        {
            try
            {
                var mongoConnection = CreateConnection(host, port);
                var mongoDatabase = mongoConnection.GetDatabase(database);
                var mongoCollection = mongoDatabase.GetMongoCollection<GPSEntry>(collection);
                mongoCollection.InsertOne(BsonSerializer.Deserialize<GPSEntry>(record));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void InsertAsmontec(string host, int port, string database, string collection, string record)
        {
            try
            {
                var mongoConnection = CreateConnection(host, port);
                var mongoDatabase = mongoConnection.GetDatabase(database);
                var mongoCollection = mongoDatabase.GetMongoCollection<AsmontecEntry>(collection);
                mongoCollection.InsertOne(BsonSerializer.Deserialize<AsmontecEntry>(record));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
