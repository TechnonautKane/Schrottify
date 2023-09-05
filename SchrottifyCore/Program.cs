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

static void LoadMP3Files(string directory)
{
    // Get all MP3 files in the directory
    string[] mp3Files = Directory.GetFiles(directory, "*.mp3", SearchOption.AllDirectories);

    // Process and display details of each MP3 file
    foreach (string file in mp3Files)
    {
        var tfile = TagLib.File.Create(file);
        Console.WriteLine($"Title: {tfile.Tag.Title ?? "Unknown"}");
        
        if (tfile.Tag.Performers.Length > 0)
        {
            Console.WriteLine($"Artist: {tfile.Tag.Performers[0]}");
        }
        else
        {
            Console.WriteLine("Artist: Unknown");
        }
        
        Console.WriteLine($"Album: {tfile.Tag.Album ?? "Unknown"}");
        Console.WriteLine("------------");
    }
}

}
