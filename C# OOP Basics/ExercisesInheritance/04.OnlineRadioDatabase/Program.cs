using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var playlist = new Playlist();

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine()
                .Split(';')
                .ToArray();

            try
            {
                var song = new Song(input[0], input[1], input[2]);
                playlist.AddSong(song);
                    Console.WriteLine("Song added.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine(playlist.ToString());
    }
}