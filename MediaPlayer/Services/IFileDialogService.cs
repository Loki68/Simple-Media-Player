using CustomMediaPlayer.DTO;

namespace CustomMediaPlayer.Services
{
    interface IFileDialogService
    {
        MediaContentDescription OpenSingleFile();
        void OpenSeveralFiles();
    }
}
