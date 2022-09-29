﻿using DMCA;
using Microsoft.Win32;
using PlanningTools.Views.Windows;
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


        #region XerParserField       

        public XerParser.Parse? XerParserField;

        #endregion


        #region Commands

        #region AboutCommand
        public ICommand AboutCommand { get; }
        private bool CanAboutCommandExecute(object p) => true;
        private void OnAboutCommandExecuted(object p)
        {
            About about = new();
            about.ShowDialog();
        }
        #endregion

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
            AboutCommand = new RelayCommand(OnAboutCommandExecuted, CanAboutCommandExecute);
            OpenFileDialogCommand = new RelayCommand(OnOpenFileCommandExecuted, CanOpenFileCommandExecute);
            ParseXerCommand = new RelayCommand(OnParseXerCommandExecuted, CanParseXerCommandExecute);
            DmcaAnalyzisCommand = new RelayCommand(OnDmcaAnalyzisCommandExecuted, CanDmcaAnalyzisCommandExecute);
        }
    }
}
