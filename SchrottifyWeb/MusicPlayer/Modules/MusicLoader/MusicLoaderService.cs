using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicLoader
{
    public class MusicLoaderService
    {
        private readonly string _musicDirectoryPath;

        public MusicLoaderService(string musicDirectoryPath)
        {
            _musicDirectoryPath = musicDirectoryPath ?? throw new ArgumentNullException(nameof(musicDirectoryPath));
            if (!Directory.Exists(_musicDirectoryPath))
            {
                throw new DirectoryNotFoundException($"The provided directory {_musicDirectoryPath} was not found.");
            }
        }

        public List<string> GetAllMusicFiles()
        {
            return Directory.GetFiles(_musicDirectoryPath, "*.mp3", SearchOption.AllDirectories).ToList();
        }
    }
}
