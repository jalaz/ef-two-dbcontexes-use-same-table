using System.Data.Entity;

namespace EFNewMigrationTests
{
    public class SongContext : DbContext
    {
        public SongContext() : base("name=SongContext")
        {
        }

        public DbSet<Song> Songs { get; set; }
    }
}