using CustomMediaPlayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediaPlayer.Services
{
    interface IFileDialogService
    {
         List<MediaContentDescription> OpenFiles();
    }
}
