namespace Iterator.Models;

public class Song(string title, string artist, string genre, int duration, int year)
{
    public string Title { get; set; } = title;
    public string Artist { get; set; } = artist;
    public string Genre { get; set; } = genre;
    public int DurationSeconds { get; set; } = duration;
    public int Year { get; set; } = year;

    public override string ToString()
    {
        return $"{Title} - {Artist} ({Genre}, {Year})";
    }
}
