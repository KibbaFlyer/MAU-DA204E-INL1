using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment_1
{
    internal class Album
    {
        private string _albumName;
        private string _artistName;
        private int _numOfTracks;

        public void Start()
        {
            Console.Title = "Album";
            Console.WriteLine();
            Console.WriteLine("Welcome to the Album listener");
            Console.WriteLine();
            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            DisplayAlbumInfo();
        }
        private void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            _albumName = Console.ReadLine();
        }
        private void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {_albumName}?");
            _artistName = Console.ReadLine();
        }
        private void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {_albumName} have?");
            _numOfTracks = Convert.ToInt16(Console.ReadLine());
        }
        private void DisplayAlbumInfo()
        {
            Console.WriteLine(
                $"\nAlbum name: {_albumName}" +
                $"\nArtist/Band: {_artistName}" +
                $"\nNumber of tracks: {_numOfTracks}" +
                $"\nEnjoy listening!");
        }

    }
}
