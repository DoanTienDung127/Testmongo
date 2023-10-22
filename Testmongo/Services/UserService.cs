using Testmongo.Models;
using MongoDB.Driver;

namespace Testmongo.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<user> _users;
        public UserService(ITestDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<user>(settings.TestCoursesCollectionName);
        }
        public user Create(user user)
        {
            _users.InsertOne(user);
            return user;
        }

        public user Get(string id)
        {
            return _users.Find(user => user.id == id).FirstOrDefault();
        }

        public List<user> Getall()
        {
            return _users.Find(user => true).ToList();
        }

        public void Remove(string id)
        {
            _users.DeleteOne(user => user.id == id);
        }

        public void Update(string id, user user)
        {
            _users.ReplaceOne(user => user.id == id, user);
        }
    }
}
