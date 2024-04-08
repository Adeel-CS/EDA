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
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewerViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
