using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore;

namespace VoicePolarity
{
    public class VoicePolarityDBContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<History> Histories => Set<History>();

        public string DBConnectionStr = "server=localhost; user=root; password=example; database=VoicePolarityDB;";
        public VoicePolarityDBContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost; user=root; password=example; database=VoicePolarityDB;", new MySqlServerVersion(new Version(8, 1, 0)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>().Property(u => u.ID).ValueGeneratedOnAdd();

            modelBuilder.Entity<History>().HasKey(h => h.ID);
            modelBuilder.Entity<History>().Property(h => h.ID).ValueGeneratedOnAdd();
        }

    }
    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<History> History { get; set; } = new List<History>();
    }

    public class History
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string FilePath { get; set; }
        public string TTSText { get; set; }
    }
}
