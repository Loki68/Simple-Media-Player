using CustomMediaPlayer.DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMediaPlayer.Services
{
    class FileDialogService : IFileDialogService
    {
        private readonly OpenFileDialog _openFileDialog;
        private List<MediaContentDescription> _list;
        private int _listLength;
        public FileDialogService()
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.Multiselect = true;
        }

        public List<MediaContentDescription> OpenFiles()
        {
            OpenFileDialog();
            SetListLength();
            CreateList();
            SetFileData();

            return _list;
        }

        private void OpenFileDialog()
        {
            _openFileDialog.ShowDialog();
            
        }

        private void SetListLength()
        {
            _listLength = _openFileDialog.FileNames.Length;
        }

        private void CreateList()
        {
            _list = new List<MediaContentDescription>(_listLength);
        }

        private void SetFileData()
        {
            for(int i = 0; i < _listLength; i++)
            {
                _list.Add( new MediaContentDescription
                {
                    FileId = i + 1,
                    FileAddress = new Uri(_openFileDialog.FileNames[i]),
                    FileName = _openFileDialog.SafeFileNames[i]
                });
            }
        }

    }
}