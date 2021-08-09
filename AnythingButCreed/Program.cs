using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Song
    //how to require doc property have user inputted value with constructor
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            var allSongs = new List<Song>();

            allSongs.Add(new Song("Elton John", "Tiny Dancer"));
            allSongs.Add(new Song("Beastie Boys", "Intergalactic"));
            allSongs.Add(new Song("Creed", "With Arms Wide Open"));

            var goodSongs = allSongs.Where(song => !song.Artist.Contains("Creed"));

            Console.WriteLine("GOOD SONGS");

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist}");
            }
        }
    }

  
}
