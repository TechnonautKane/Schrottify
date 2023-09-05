using System;
using System.IO;
using TagLib;



class Program
{
    static void Main()
    {
        string musicDirectory = "/home/user/Desktop/Schrottify";
        LoadMP3Files(musicDirectory);
    }

static void PlayMP3(string filePath)
{
    var process = new System.Diagnostics.Process
    {
        StartInfo = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "mpg123",
            Arguments = $"\"{filePath}\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        }
    };
    process.Start();
    process.WaitForExit();
}


static void LoadMP3Files(string directory)
{
    // Get all MP3 files in the directory
    string[] mp3Files = Directory.GetFiles(directory, "*.mp3", SearchOption.AllDirectories);

    // Process and display details of each MP3 file
 foreach (string file in mp3Files)
{
    Console.WriteLine($"Processing file: {file}");
    var tfile = TagLib.File.Create(file);
    
    string defaultTitle = Path.GetFileNameWithoutExtension(file);
    string title = string.IsNullOrEmpty(tfile.Tag.Title) ? defaultTitle : tfile.Tag.Title;
    string artist = (tfile.Tag.Performers.Length > 0 && !string.IsNullOrEmpty(tfile.Tag.Performers[0])) ? tfile.Tag.Performers[0] : "Unknown Artist";
    string album = string.IsNullOrEmpty(tfile.Tag.Album) ? "Unknown Album" : tfile.Tag.Album;

    Console.WriteLine($"Title: {title}");
    Console.WriteLine($"Artist: {artist}");
    Console.WriteLine($"Album: {album}");
    Console.WriteLine("------------");
     // Play the MP3 file
    PlayMP3(file);
}

}

}
