﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using Dynamo.Core;
using Dynamo.Graph.Workspaces;
using Dynamo.Utilities;
using Dynamo.ViewModels;
using Dynamo.Wpf.Extensions;
using DynamoGraphUpdater.Controls;

namespace DynamoGraphUpdater
{
    public class DynamoGraphUpdaterViewModel : NotificationObject, IDisposable
    {
        #region Fields and Properties
        private readonly ViewLoadedParams _viewLoadedParamsInstance;
        internal DynamoViewModel DynamoViewModel;
        internal HomeWorkspaceModel CurrentWorkspace;
        #endregion


        /// <summary>
        /// Collection of graphs loaded for upgrading
        /// </summary>
        public ObservableCollection<UpdateableGraphsViewModel> UpdateableGraphs { get; set; }

        /// <summary>
        /// The potential target versions
        /// </summary>
        public ObservableCollection<TargetDynamoVersion> TargetVersions { get; set; }

        private int _currentPageIndex;
        public int CurrentPageIndex
        {
            get { return _currentPageIndex; }
            set { _currentPageIndex = value; RaisePropertyChanged(nameof(CurrentPageIndex)); RaisePropertyChanged(nameof(CurrentPage)); }
        }
        private int _currentPage;
        public int CurrentPage
        {
            get { return _currentPageIndex + 1; }
            set { _currentPage = value; RaisePropertyChanged(nameof(CurrentPage)); }
        }

        /// <summary>
        ///     The source path containing dynamo graphs to be exported
        /// </summary>
        public PathViewModel SourcePathViewModel { get; set; }

        public DynamoGraphUpdaterViewModel(ViewLoadedParams p)
        {
            if (p == null) return;
            _viewLoadedParamsInstance = p;
            
            //store our source path and subscribe to changed event
            SourcePathViewModel = new PathViewModel
            { Type = PathType.Source, Owner = _viewLoadedParamsInstance.DynamoWindow };

            SourcePathViewModel.PropertyChanged += SourcePathPropertyChanged;

            CurrentPageIndex = 0;

            //Load our target versions from json TODO: make this read extra folder
            TargetVersions = new ObservableCollection<TargetDynamoVersion>()
            {
                new TargetDynamoVersion("2.5","Revit", "2021",false,false,true),
                new TargetDynamoVersion("2.6","Revit", "2021.1",false,false,true),
                new TargetDynamoVersion("2.10","Revit", "2022",false,false,true),
                new TargetDynamoVersion("2.12","Revit", "2022.1",false,true,true),
                new TargetDynamoVersion("2.13","Revit", "2023",true,true,true),
                new TargetDynamoVersion("2.14","Revit"," 2024",true,true,true),

                new TargetDynamoVersion("2.10","Civil3D", "2022",false,false,true),
                new TargetDynamoVersion("2.13","Civil3D", "2023",true,true,true),
                new TargetDynamoVersion("2.14","Civil3D"," 2024",true,true,true),
            };

        }
        // Handles source path changed
        private void SourcePathPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            var pathVM = sender as PathViewModel;
            if (pathVM == null) return;
            if (propertyChangedEventArgs.PropertyName == nameof(PathViewModel.FolderPath))
            {
                if (pathVM.Type == PathType.Source)
                {
                    SourceFolderChanged(pathVM);
                }
                else
                {
                    //TargetFolderChanged();
                }

                //RaisePropertyChanged(nameof(CanExport));
            }
        }
        // Update graphs if source folder is changed by the UI
        private void SourceFolderChanged(PathViewModel pathVM)
        {
            UpdateableGraphs = new ObservableCollection<UpdateableGraphsViewModel>();

            var files = Utilities.GetAllFilesOfExtension(pathVM.FolderPath)?.OrderBy(x => x);
            if (files == null)
                return;

            var graphs = new List<UpdateableGraphViewModel>();

            foreach (var file in files)
            {
                graphs.Add(new UpdateableGraphViewModel(Utilities.GetDynamoVersionForGraph(file), file));

            }

            var groupedByVersion = graphs.GroupBy(g => g.TruncatedVersion);

            foreach (var group in groupedByVersion.OrderBy(g => g.Key.Major).ThenBy(g => g.Key.Minor))
            {
                var updateableGraph = new UpdateableGraphsViewModel(group.Key, group.ToList());

                UpdateableGraphs.Add(updateableGraph);
            }

            RaisePropertyChanged(nameof(UpdateableGraphs));
        }


        public void Dispose()
        {
            CurrentWorkspace = null;
            DynamoViewModel = null;
        }
    }
}
