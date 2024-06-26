﻿using mvvm.Stores;
using mvvm.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace mvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        public App()
        {
            _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewerViewModel(_selectedYouTubeViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
