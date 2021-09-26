using CustomMediaPlayer.DTO;
using Microsoft.Win32;
using System;

namespace CustomMediaPlayer.Services
{
    class FileDialogService : IFileDialogService
    {
        private readonly OpenFileDialog _openFileDialog;
        public FileDialogService()
        {
            _openFileDialog = new OpenFileDialog();
        }

        public void OpenSeveralFiles()
        {
            throw new NotImplementedException();
        }

        public MediaContentDescription OpenSingleFile()
        {
            _openFileDialog.ShowDialog();
            return new MediaContentDescription
            {
                FileAddress = _openFileDialog.FileName,
                FileName = _openFileDialog.SafeFileName
            };
        }
    }
}
