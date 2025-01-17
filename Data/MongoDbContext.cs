using EventsCoolFun_ECF_.Models;
using MongoDB.Driver;

namespace EventsCoolFun_ECF_.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDbConnection"));
            _database = client.GetDatabase("EventManagementDb");
        }

        public IMongoCollection<Participant> Participants => _database.GetCollection<Participant>("Participants");
    }
}
