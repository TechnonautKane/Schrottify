using System;
using System.IO;

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

        // Print out the names of the loaded files
        foreach (string file in mp3Files)
        {
            Console.WriteLine(file);
        }
    }
}
