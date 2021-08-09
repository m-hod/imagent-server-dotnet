using Microsoft.EntityFrameworkCore;
using imagent_server.Models;

namespace imagent_server.Data
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
         public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
         {
             
         }
         
         public DbSet<User> Users {get; set;} = null!;
    }
}