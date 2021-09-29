using CustomMediaPlayer.DTO;
using System.Collections.Generic;

namespace CustomMediaPlayer.Services
{
    interface IFileService
    {
        void ReadPlaylyst(string playlistPath);
        void WritePlaylist(string playlistPath, List<MediaContentDescription> playlist);
    }
}
