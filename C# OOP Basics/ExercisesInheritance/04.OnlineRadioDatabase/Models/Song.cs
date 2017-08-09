using System;

public class Song
{
    private string artistName;
    private string songName;
    private string songDuration;

    public Song(string artistName, string songName, string songDuration)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongDuration = songDuration;
    }

    public string ArtistName
    {
        get { return this.artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }

            this.artistName = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }

            this.songName = value;
        }
    }

    public string SongDuration
    {
        get { return this.songDuration; }
        set
        {
            var timeTokens = value.Split(':');
            int minutes;
            int seconds;
            bool areMinutesCorrect = int.TryParse(timeTokens[0], out minutes);
            bool areSecondsCorrect = int.TryParse(timeTokens[1], out seconds);

            if (areMinutesCorrect && areSecondsCorrect)
            {
                if (minutes < 0 || minutes > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
                if (seconds < 0 || seconds > 59)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }

                this.songDuration = value;
            }
            else
            {
                throw new ArgumentException("Invalid song length.");
            }
        }
    }
}