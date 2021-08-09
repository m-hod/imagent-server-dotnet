using imagent_server.Models;
using Microsoft.EntityFrameworkCore;

namespace imagent_server.Data
{
    public interface IApplicationContext
    {
        DbSet<User> Users {get; set;}

        int SaveChanges(bool acceptAllChangesOnSuccess = default);
    }
}