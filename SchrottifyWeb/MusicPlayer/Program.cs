using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

// You might need to add the namespace where your MusicLoaderService is defined
using namespace MusicLoader
;

namespace MusicPlayer
{
    public class Program
    {


        
        public static void Main(string[] args)
        {
            // Testing the MusicLoaderService - uncomment to test
           
            var musicDirectory = "/home/user/Desktop/Schrottify/Music";
            var musicLoader = new MusicLoaderService(musicDirectory);
            var allMusicFiles = musicLoader.GetAllMusicFiles();

            Console.WriteLine("Found the following MP3 files:");
            foreach (var file in allMusicFiles)
            {
                Console.WriteLine(file);
            }
          

            // Original Main method to run the web app
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
