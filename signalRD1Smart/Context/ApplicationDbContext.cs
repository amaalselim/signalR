using Microsoft.EntityFrameworkCore;
using signalRD1Smart.Models;

namespace signalRD1Smart.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
        public DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RealtimeChat;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
}
