class Song
{
    public string Title { get; set; }
    public string Band { get; set; }
    public int Duration { get; set; }
    public int PlayCount { get; set; }
    public bool Favorite { get; set; }
    public string DisplayName => $"{Title} - {Band}";
    public void DisplaySongDetails()
    {
        Console.WriteLine($"Song Title: {Title}");
        Console.WriteLine($"Band: {Band}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine($"Play Count: {PlayCount}");
        if (Favorite)
        {
            Console.WriteLine("Favorite");
        }
    }
}