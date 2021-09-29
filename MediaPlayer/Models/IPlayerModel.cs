using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.Models
{
    interface IPlayerModel
    {
        //string FileName { get; set; }
        //string FullFileName { get; set; }

        //MediaContentDescription MediaContent { get; set; }
        List<MediaContentDescription> Playlist { get;  }
        MediaContentDescription MdiaContentDescription { get; set; }

        void OpenFiles();
    }
}
