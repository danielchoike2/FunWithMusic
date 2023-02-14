using System;
namespace FunWithMusic
{ // start of namespace
    class Program {

        enum Genre
        { //start of enum
            Electronic,
            VaporWave,
            HipHop,
            Metal,
            Country
        } // end of enum 
        struct Music

        {// start of struct

            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title,string artist, string album, string length, Genre genre)
            {// start of public music 

                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre; 
            }// end of public music 
            public void setTitle(string title)
            {// start of title void
                Title = title;
            }// end of title void 
            public void setArtist(string artist)
            {// start of artist void
                Artist = artist;
            }// end of artist void 

            public void setAlbum(string album)
            {// start of album void
                Album = album;
            }// end of album void 

            public void setLength(string length)
            {// start of album void
                Length = length;
            }// end of album void 

            public void setGenre(Genre genre)
            {// start of genre void
                Genre = genre;
            }// end of genre void 

            public string Display() { 
            
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;


            }



        }// end of struct 



        static void Main(string[] args)
    {//main method 
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album of the song?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("E - electronic\nV - vaporwave\nH - hiphop\nM - metal\nC - country");
            Genre tempGenre = Genre.Electronic;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {// start of switch 
                case 'E':
                    tempGenre = Genre.Electronic;
                    break;
                case 'V':
                    tempGenre = Genre.VaporWave;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
            }// end of switch 

            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");

            Music newMusic = music;

            Console.WriteLine("What is the next song on the album?");
            newMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the song?");
            newMusic.setLength(Console.ReadLine());
            Console.WriteLine($"{newMusic.Display()}");

        }//end of main method 
   }// end of class 
} // end of namespace 
