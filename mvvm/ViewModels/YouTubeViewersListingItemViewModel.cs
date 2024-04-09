using mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public YouTubeViewer YouTubeViewer { get; }

        public string Username => YouTubeViewer.Username;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public YouTubeViewer SelectedYouTubeViewer { get; internal set; }

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
        {
            YouTubeViewer = youTubeViewer;
        }

    }
}
