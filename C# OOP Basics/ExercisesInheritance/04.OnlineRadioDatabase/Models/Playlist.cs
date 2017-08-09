using System.Collections.Generic;
using System.Linq;

public class Playlist
{
    private List<Song> allSongs;
    private int hours;
    private int minutes;
    private int seconds;


    public Playlist()
    {
        this.hours = 0;
        this.minutes = 0;
        this.seconds = 0;
        this.allSongs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        var songDuration = song.SongDuration
            .Split(':')
            .Select(int.Parse)
            .ToArray();

        this.allSongs.Add(song);

        this.seconds += songDuration[1];
        if (this.seconds >= 60)
        {
            this.minutes++;
            this.seconds -= 60;
        }

        this.minutes += songDuration[0];
        if (this.minutes >= 60)
        {
            this.hours++;
            this.minutes -= 60;
        }
    }

    public override string ToString()
    {
        return $"Songs added: {this.allSongs.Count}\n" +
               $"Playlist length: {this.hours}h {this.minutes}m {this.seconds}s";
    }
}