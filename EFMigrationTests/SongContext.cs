using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace EFMigrationTests
{
    public class SongContext : DbContext
    {
        public SongContext() : base("name=SongContext")
        {
        }

        public DbSet<Song> Songs { get; set; }
    }
}