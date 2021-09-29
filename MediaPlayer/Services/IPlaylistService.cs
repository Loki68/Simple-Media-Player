using CustomMediaPlayer.DTO;
using System.Collections.Generic;

namespace CustomMediaPlayer.Services
{
    interface IPlaylistService
    {
        void GetPlaylist();
        void GetPlaylistCollection();
        void CreateOrUpdatePlaylist(string playlistPath, List<MediaContentDescription> playlist);
    }
}
