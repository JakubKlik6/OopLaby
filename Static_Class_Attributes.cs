using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day",200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Song baby = new Song("Baby", "Justin Bieber", 350);
            Console.WriteLine(Song.songCount);
            Song papercuts = new Song("Papercuts", "Vince Staples", 250);
            Console.WriteLine(Song.songCount);
            //I can check how many objects I have (class) created

            Console.WriteLine(holiday.getsongCount());

            Console.ReadLine();
        }
    }
}


//Class

using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Song
    {
        public string title, artist;
        public int duration;
        public static int songCount = 0;        //static attribute

        public Song(string aTitle,string aArtist,int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getsongCount()
        {
            return songCount;
        }


    }
}
