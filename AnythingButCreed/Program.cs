using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var AllSongs = CreatePlaylist();
            var GoodSongs = new List<Song>();

           

            var noCreed = AllSongs.Where(song => song.Artist != "Creed");
            GoodSongs.AddRange(noCreed);

            foreach (var tune in GoodSongs)
            {
                Console.WriteLine(tune.Artist + " " + tune.Name);
            }

        }

        private static List<Song> CreatePlaylist()
        {
            var allSongs = new List<Song>();
            var bad = new Song("U2", "Bad");
            var clocks = new Song("Coldplay", "Clocks");

            allSongs.Add(bad);
            allSongs.Add(clocks);
            allSongs.Add(new Song("Creed", "Let's Eat Papaya!"));
            allSongs.Add(new Song("Lady Gaga", "Bad Romance"));
            allSongs.Add(new Song("Led Zeppelin", "Kashmir"));
            allSongs.Add(new Song("The Killers", "Human"));
            allSongs.Add(new Song("Puccini", "Nessum Dorma"));
            allSongs.Add(new Song("Creed", "My Butt Hurts"));
            allSongs.Add(new Song("The Sundays", "Summertime"));
            allSongs.Add(new Song("Muse", "Map Of The Problematique"));
            allSongs.Add(new Song("Creed", "Eat Your Vegetables!"));
            allSongs.Add(new Song("AC/DC", "Highway To Hell"));

            return allSongs;
        }
    }
}
