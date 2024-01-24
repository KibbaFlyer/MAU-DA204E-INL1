using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment_1
{
    // Album class, to write out album information to the user
    internal class Album
    {
        private string _albumName;
        private string _artistName;
        private int _numOfTracks;
        // Start method introduces the user and calls the different methods
        // to create an album with all related information
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
        // This method reads an album name entered by the user
        private void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            _albumName = Console.ReadLine();
        }
        // This method reads an artist name entered by the user
        private void ReadArtistName()
        {
            Console.WriteLine($"What is the name of the Artist or Band for {_albumName}?");
            _artistName = Console.ReadLine();
        }
        // This method reads the number of tracks on the album according to the user
        private void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {_albumName} have?");
            _numOfTracks = Convert.ToInt16(Console.ReadLine());
        }
        // This method displays the information in an orderly manner
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
