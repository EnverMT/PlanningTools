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

        #region Calendar
        private List<XerParser.Models.Classes.CALENDAR>? _calendar = null;
        public List<XerParser.Models.Classes.CALENDAR>? Calendar
        {
            get => _calendar;
            set => Set(ref _calendar, value);
        }
        #endregion

        #region Currtypes
        private List<XerParser.Models.Classes.CURRTYPE>? _currtypes = null;
        public List<XerParser.Models.Classes.CURRTYPE>? Currtypes
        {
            get => _currtypes;
            set => Set(ref _currtypes, value);
        }
        #endregion

        #region Memotypes
        private List<XerParser.Models.Classes.MEMOTYPE>? _memotypes = null;
        public List<XerParser.Models.Classes.MEMOTYPE>? Memotypes
        {
            get => _memotypes;
            set => Set(ref _memotypes, value);
        }
        #endregion

        #region Nonwork
        private List<XerParser.Models.Classes.NONWORK>? _nonwork = null;
        public List<XerParser.Models.Classes.NONWORK>? Nonwork
        {
            get => _nonwork;
            set => Set(ref _nonwork, value);
        }
        #endregion

        #region Obs
        private List<XerParser.Models.Classes.OBS>? _obs = null;
        public List<XerParser.Models.Classes.OBS>? Obs
        {
            get => _obs;
            set => Set(ref _obs, value);
        }
        #endregion

        #region Project
        private List<XerParser.Models.Classes.PROJECT>? _project = null;
        public List<XerParser.Models.Classes.PROJECT>? Project
        {
            get => _project;
            set => Set(ref _project, value);
        }
        #endregion

        #region RiskType
        private List<XerParser.Models.Classes.RISKTYPE>? _riskType = null;
        public List<XerParser.Models.Classes.RISKTYPE>? RiskType
        {
            get => _riskType;
            set => Set(ref _riskType, value);
        }
        #endregion

        #region RsrcCurvData
        private List<XerParser.Models.Classes.RSRCCURVDATA>? _rsrcCurvData = null;
        public List<XerParser.Models.Classes.RSRCCURVDATA>? RsrcCurvData
        {
            get => _rsrcCurvData;
            set => Set(ref _rsrcCurvData, value);
        }
        #endregion

        #region UdfType
        private List<XerParser.Models.Classes.UDFTYPE>? _udfType = null;
        public List<XerParser.Models.Classes.UDFTYPE>? UdfType
        {
            get => _udfType;
            set => Set(ref _udfType, value);
        }
        #endregion

        #region Umeasure
        private List<XerParser.Models.Classes.UMEASURE>? _umeasure = null;
        public List<XerParser.Models.Classes.UMEASURE>? Umeasure
        {
            get => _umeasure;
            set => Set(ref _umeasure, value);
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
                Calendar = xp.Calendar.list;
                Currtypes = xp.Currtypes.list;
                Memotypes = xp.Memotypes.list;
                Nonwork = xp.Nonwork.list;
                Obs = xp.Obs.list;
                RiskType = xp.RiskType.list;
                RsrcCurvData = xp.RsrcCurvData.list;
                UdfType = xp.UdfType.list;
                Umeasure = xp.Umeasure.list;
                Project = xp.Project.list;
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
