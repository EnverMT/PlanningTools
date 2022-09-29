using DMCA;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
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

        #region TasksCount

        private int? _tasksCount = null;
        public int? TasksCount
        {
            get => _tasksCount;
            set => Set(ref _tasksCount, value);
        }

        #endregion

        #region RelationshipsCount

        private int? _relationshipsCount = null;
        public int? RelationshipsCount
        {
            get => _relationshipsCount;
            set => Set(ref _relationshipsCount, value);
        }

        #endregion

        #region ParsedTypes

        #region ActvCode
        private List<XerParser.Models.Classes.ACTVCODE>? _actvCode = null;
        public List<XerParser.Models.Classes.ACTVCODE>? ActvCode
        {
            get => _actvCode;
            set => Set(ref _actvCode, value);
        }
        #endregion

        #region ActvType
        private List<XerParser.Models.Classes.ACTVTYPE>? _actvType = null;
        public List<XerParser.Models.Classes.ACTVTYPE>? ActvType
        {
            get => _actvType;
            set => Set(ref _actvType, value);
        }
        #endregion

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

        #region ProjCost
        private List<XerParser.Models.Classes.PROJCOST>? _projCost = null;
        public List<XerParser.Models.Classes.PROJCOST>? ProjCost
        {
            get => _projCost;
            set => Set(ref _projCost, value);
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

        #region ProjWbs
        private List<XerParser.Models.Classes.PROJWBS>? _projWbs = null;
        public List<XerParser.Models.Classes.PROJWBS>? ProjWbs
        {
            get => _projWbs;
            set => Set(ref _projWbs, value);
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

        #region Rsrc
        private List<XerParser.Models.Classes.RSRC>? _rsrc = null;
        public List<XerParser.Models.Classes.RSRC>? Rsrc
        {
            get => _rsrc;
            set => Set(ref _rsrc, value);
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

        #region RsrcRate
        private List<XerParser.Models.Classes.RSRCRATE>? _rsrcRate = null;
        public List<XerParser.Models.Classes.RSRCRATE>? RsrcRate
        {
            get => _rsrcRate;
            set => Set(ref _rsrcRate, value);
        }
        #endregion

        #region SchedOptions
        private List<XerParser.Models.Classes.SCHEDOPTIONS>? _schedOptions = null;
        public List<XerParser.Models.Classes.SCHEDOPTIONS>? SchedOptions
        {
            get => _schedOptions;
            set => Set(ref _schedOptions, value);
        }
        #endregion

        #region Tasks
        private List<XerParser.Models.Classes.TASK>? _tasks = null;
        public List<XerParser.Models.Classes.TASK>? Tasks
        {
            get => _tasks;
            set => Set(ref _tasks, value);
        }
        #endregion

        #region TaskActv
        private List<XerParser.Models.Classes.TASKACTV>? _taskActv = null;
        public List<XerParser.Models.Classes.TASKACTV>? TaskActv
        {
            get => _taskActv;
            set => Set(ref _taskActv, value);
        }
        #endregion

        #region TaskMemo
        private List<XerParser.Models.Classes.TASKMEMO>? _taskMemo = null;
        public List<XerParser.Models.Classes.TASKMEMO>? TaskMemo
        {
            get => _taskMemo;
            set => Set(ref _taskMemo, value);
        }
        #endregion

        #region TaskPred
        private List<XerParser.Models.Classes.TASKPRED>? _taskPred = null;
        public List<XerParser.Models.Classes.TASKPRED>? TaskPred
        {
            get => _taskPred;
            set => Set(ref _taskPred, value);
        }
        #endregion

        #region TaskProc
        private List<XerParser.Models.Classes.TASKPROC>? _taskProc = null;
        public List<XerParser.Models.Classes.TASKPROC>? TaskProc
        {
            get => _taskProc;
            set => Set(ref _taskProc, value);
        }
        #endregion

        #region TaskRsrc
        private List<XerParser.Models.Classes.TASKRSRC>? _taskRsrc = null;
        public List<XerParser.Models.Classes.TASKRSRC>? TaskRsrc
        {
            get => _taskRsrc;
            set => Set(ref _taskRsrc, value);
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

        #region UdfValue
        private List<XerParser.Models.Classes.UDFVALUE>? _udfValue = null;
        public List<XerParser.Models.Classes.UDFVALUE>? UdfValue
        {
            get => _udfValue;
            set => Set(ref _udfValue, value);
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


        #region XerParserField       

        public XerParser.Parse? XerParserField;

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
            }
        }
        #endregion

        #region ParseXerCommand
        public ICommand ParseXerCommand { get; }
        private bool CanParseXerCommandExecute(object p) => FilePath != null && File.Exists(FilePath);
        private void OnParseXerCommandExecuted(object p)
        {
            XerParserField = new XerParser.Parse(FilePath!, new System.Globalization.CultureInfo("ru-RU")
            {
                NumberFormat = { NumberDecimalSeparator = "," }
            });
        }
        #endregion

        #region DmcaAnalyzisCommand
        public ICommand DmcaAnalyzisCommand { get; }
        private bool CanDmcaAnalyzisCommandExecute(object p) => XerParserField != null;
        private void OnDmcaAnalyzisCommandExecuted(object p)
        {
            DMCA14_Analyzis dmca14_Analyzis = new(XerParserField!);
            TasksCount = dmca14_Analyzis.ActivitiesCount;
            RelationshipsCount = dmca14_Analyzis.RelationshipsCount;
        }
        #endregion

        #endregion
        public MainWindowViewModel()
        {
            OpenFileDialogCommand = new RelayCommand(OnOpenFileCommandExecuted, CanOpenFileCommandExecute);
            ParseXerCommand = new RelayCommand(OnParseXerCommandExecuted, CanParseXerCommandExecute);
            DmcaAnalyzisCommand = new RelayCommand(OnDmcaAnalyzisCommandExecuted, CanDmcaAnalyzisCommandExecute);
        }
    }
}
