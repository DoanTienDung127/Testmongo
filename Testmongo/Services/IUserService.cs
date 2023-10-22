using Testmongo.Models;

namespace Testmongo.Services
{
    public interface IUserService
    {
        List<user> Getall();
        user Get(string id);
        user Create(user user);
        void Update(string id, user user);
        void Remove(string id);
    }
}
