using imagent_server.Data;
using imagent_server.Models;

namespace imagent_server.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationContext _context;
        public UserRepository(IApplicationContext context)
        {
            _context = context;
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

    }
}