using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123_homework03_song
{
    class Program
    {
        [Flags]
        enum SongGenre
        {
            Unclassified = 0,
            Pop = 0b1,
            Rock = 0b10,
            Blues = 0b100,
            Country = 0b1_000,
            Metal = 0b10_000,
            Soul = 0b100_000
        }
        static void Main(string[] args)
        {
            //To test the constructor and the ToString method
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            //This is first time that you are using the bitwise or. It is used to specify a combination of genres
            Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

            Library.LoadSongs("Week_03_lab_09_songs4.txt");     //Class methods are invoke with the class name
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
            Library.DisplaySongs(length);

        }
        class Song
        {
            public string Title { get; }
            public string Artist { get; }
            public double Length { get; }
            public SongGenre Genre { get; }
            public Song(string title, string artist, double length, SongGenre genre)
            {
                Title = title;
                Artist = artist;
                Length = length;
                Genre = genre;
            }
            public override string ToString()
            {
                return $"{Title} by {Artist} ({Genre}) {Length}min  \n\n ";
            }
        }
        static class Library
        {
            private static List<Song> songs = new List<Song>();
            //public static void LoadSongs(string filename)
            //{
            //    filename = "Week_03_lab_09_songs4.txt";

            //    TextReader reader = new StreamReader(filename);
            //    string line = reader.ReadLine();


            //    while (line != null)
            //    {
            //        //Console.WriteLine(line);
            //        //line = reader.ReadLine();

            //        string title = line;
            //        string artist = line;
            //        double length = Convert.ToDouble(line);
            //        SongGenre genre = (SongGenre)Enum.Parse(typeof(SongGenre), line);

            //        Song songs = new Song(title, artist, length, genre);

            //        // i keep getting an exception error on this block of code professor so i cant finish the whole homework. im stuck
            //    }

            //    reader.Close();
            //}
            public static void LoadSongs(string fileName)
            {
                TextReader reader = new StreamReader(fileName);
                songs = new List<Song>();
                string line = reader.ReadLine();
                string artist;
                string title;
                double length;
                SongGenre genre;
                while ((title = reader.ReadLine()) != null)
                {

                    artist = line;
                    length = Convert.ToDouble(reader.ReadLine());
                    genre = (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine());
                    songs.Add(new Song(artist, title, length, genre));
                    line = reader.ReadLine();
                }

                reader.Close();
            }

            public static void DisplaySongs()
            {

            }
            public static void DisplaySongs(double longerThan)
            {

            }
            public static void DisplaySongs(SongGenre genre)
            {

            }
            public static void DisplaySongs(string artist)
            {

            }
        }
    }
}
