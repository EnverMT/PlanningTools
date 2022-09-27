using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows.Input;
using XerParser.Infrastructure.Commands;
using XerParser.ViewModels.Base;

namespace XerParser.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Planning Tools";

        /// <summary>Window title</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Filename

        private string? _filePath = null;
        public string? FilePath
        {
            get => _filePath;
            set => Set(ref _filePath, value);
        }

        #endregion



        #region ParsedTypes

        #region Currtypes
        private List<XerParser.Models.Currtype> _currtypes = null;
        public List<XerParser.Models.Currtype> Currtypes
        {
            get => _currtypes;
            set => Set(ref _currtypes, value);
        }
        #endregion

        #region Memotype
        private List<XerParser.Models.Memotype> _memotypes = null;
        public List<XerParser.Models.Memotype> Memotypes
        {
            get => _memotypes;
            set => Set(ref _memotypes, value);
        }
        #endregion

        #region Nonwork
        private List<XerParser.Models.Nonwork> _nonworktypes = null;
        public List<XerParser.Models.Nonwork> Nonworktypes
        {
            get => _nonworktypes;
            set => Set(ref _nonworktypes, value);
        }
        #endregion

        #region OBS
        private List<XerParser.Models.OBS> _OBStypes = null;
        public List<XerParser.Models.OBS> OBStypes
        {
            get => _OBStypes;
            set => Set(ref _OBStypes, value);
        }
        #endregion

        #endregion



        #region Commands

        #region OpenFileCommand
        public ICommand OpenFileDialogCommand { get; }
        private bool CanOpenFileCommandExecute(object p) => true;
        private void OnOpenFileCommandExecuted(object p)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                var xp = new XerParser.Parse(_filePath, new System.Globalization.CultureInfo("ru-RU")
                {
                    NumberFormat = { NumberDecimalSeparator = "," }
                });
                Currtypes = xp.currtypesClassList;
                Memotypes = xp.memotypesClassList;
                Nonworktypes = xp.nonworkClassList;
                OBStypes = xp.OBSClassList;
            }
        }
        #endregion

        #endregion
        public MainWindowViewModel()
        {
            OpenFileDialogCommand = new RelayCommand(OnOpenFileCommandExecuted, CanOpenFileCommandExecute);
        }
    }
}
