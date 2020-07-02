using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDML.Core.Extensions
{
    public static class MongoExtensions
    {
        public static bool CollectionExists(this IMongoDatabase db, string collectionName)
        {
            var filter = new BsonDocument("name", collectionName);
            //filter by collection name
            var collections = db.ListCollections(new ListCollectionsOptions { Filter = filter });
            //check for existence
            return collections.Any();
        }

        public static IMongoCollection<T> GetMongoCollection<T>(this IMongoDatabase db, string collection)
            where T : class
        {
            if (!db.CollectionExists(collection))
            {
                db.CreateCollection(collection);
            }
            return db.GetCollection<T>(collection);
        }
    }
}
