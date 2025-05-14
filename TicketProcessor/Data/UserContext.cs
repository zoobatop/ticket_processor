using Microsoft.EntityFrameworkCore;
using TicketProcessor.Models;

namespace TicketProcessor.Data {
    public class UserContext: DbContext {
        public UserContext(DbContextOptions<UserContext> options): base(options) {}

        public DbSet<Usuario> Users { get; set;}
        
    }
}
