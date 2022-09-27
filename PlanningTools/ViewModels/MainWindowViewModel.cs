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
        private List<XerParser.Models.Classes.Currtype>? _currtypes = null;
        public List<XerParser.Models.Classes.Currtype>? Currtypes
        {
            get => _currtypes;
            set => Set(ref _currtypes, value);
        }
        #endregion

        #region Memotypes
        private List<XerParser.Models.Classes.Memotype>? _memotypes = null;
        public List<XerParser.Models.Classes.Memotype>? Memotypes
        {
            get => _memotypes;
            set => Set(ref _memotypes, value);
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
                var xp = new XerParser.Parse(FilePath, new System.Globalization.CultureInfo("ru-RU")
                {
                    NumberFormat = { NumberDecimalSeparator = "," }
                });
                Currtypes = xp._Currtypes.list;
                Memotypes = xp._Memotypes.list;
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
