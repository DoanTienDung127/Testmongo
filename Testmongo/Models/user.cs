using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 

namespace Testmongo.Models
{
    [BsonIgnoreExtraElements]
    public class user
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; } = String.Empty;

        [BsonElement("userName")]
        public string userName { get; set; } = String.Empty;

        [BsonElement("phoneNo")]
        public string phoneNo { get; set; } = String.Empty;

        [BsonElement("email")]
        public string email { get; set; } = String.Empty;

        [BsonElement("password")]
        public string password { get; set; } = String.Empty;

        [BsonElement("role")]
        public string role { get; set; } = String.Empty;
       
    }
}
