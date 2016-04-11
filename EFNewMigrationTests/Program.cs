using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNewMigrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SongContext())
            {
                var song = new Song();
                song.SongName = "Rain Over Me";
                song.Author = "Pitbull";
                context.Songs.Add(song);
                context.SaveChanges();
            }

            using (var context = new SongContext())
            {
                foreach (var song in context.Songs.ToList())
                {
                    Console.WriteLine(song.SongName);
                }
            }

        }
    }
}
