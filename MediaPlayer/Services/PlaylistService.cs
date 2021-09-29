using CustomMediaPlayer.DTO;
using System;
using System.Collections.Generic;

namespace CustomMediaPlayer.Services
{
    class PlaylistService : IPlaylistService
    {
        private readonly IFileService _fileService;

        public PlaylistService()
        {
            _fileService = new FileService();
        }

        public void DeletePlaylist()
        {
            throw new NotImplementedException();
        }

        public void GetPlaylist()
        {
            throw new NotImplementedException();
        }

        public void GetPlaylistCollection()
        {
            throw new NotImplementedException();
        }

        public void CreateOrUpdatePlaylist(string playlistPath,List<MediaContentDescription> playlist)
        {
            _fileService.WritePlaylist(playlistPath, playlist);
        }
    }
}
