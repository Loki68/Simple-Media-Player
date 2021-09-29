using CustomMediaPlayer.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CustomMediaPlayer.Services
{
    class FileService : IFileService
    {
        private FileStream _fileStream;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;

        public FileService()
        {
        }
        //добавить проверки
        public void ReadPlaylyst(string playlistPath)
        {
            List<MediaContentDescription> list;

            _fileStream = new FileStream(playlistPath, FileMode.Open);
            _streamReader = new StreamReader(_fileStream);

            list = JsonSerializer.Deserialize<List<MediaContentDescription>>(_streamReader.ReadToEnd());
            _streamReader.Close();
        }

        public void WritePlaylist(string playlistPath,List<MediaContentDescription> playlist)
        {
            _fileStream = new FileStream(playlistPath, FileMode.OpenOrCreate);
            _streamWriter = new StreamWriter(_fileStream);

            string playlistData = JsonSerializer.Serialize(playlist);

            _streamWriter.Write(playlistData);
            _streamWriter.Close();
        }
    }
}
