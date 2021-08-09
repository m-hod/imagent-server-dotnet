using System.Threading.Tasks;
using imagent_server.Models;

namespace imagent_server.Repositories
{
    public interface IUserRepository
    {
         User Get(int id);
         User Add(User user);
         User Update(User user);
         void Delete(User user);
    }
}