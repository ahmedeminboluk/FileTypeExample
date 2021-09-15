using FileTypeExample.API.Configuration;
using FileTypeExample.API.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Repository
{
    public class MongoDbRepositoryBase<T> : IRepository<T> where T : IDocument
    {
        protected readonly IMongoCollection<T> _collection;
        private readonly MongoDbConfiguration _config;

        public MongoDbRepositoryBase(IOptions<MongoDbConfiguration> config)
        {
            _config = config.Value;
            MongoClient mongoClient = new MongoClient(_config.ConnectionString);
            var database = mongoClient.GetDatabase(_config.Database);
            _collection = database.GetCollection<T>(typeof(T).Name.ToLowerInvariant());
        }

        public async Task AddAsync(T document)
        {
            await _collection.InsertOneAsync(document);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.Find(x => true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
