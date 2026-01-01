class Album
{
    public string Title { get; set; }
    public string Band { get; set; }
    private List<Song> songs = new List<Song>();
    public int Duration => songs.Sum(song => song.Duration);
    public void AddSong(Song song)
    {
        songs.Add(song);
    }
    public void DisplaySongList()
    {
        foreach (var song in songs)
        {
            Console.WriteLine(song.Title);
        }
    }
    public void DisplayAlbumDetails()
    {
        Console.WriteLine($"Album Title: {Title}");
        Console.WriteLine($"Band: {Band}");
        Console.WriteLine($"Duration: {Duration}");
    }
}
