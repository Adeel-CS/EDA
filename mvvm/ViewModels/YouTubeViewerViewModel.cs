using mvvm.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm.ViewModels
{
    internal class YouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel? YouTubeViewersListingViewModel { get; }

        public YouTubeViewersDetailsViewModel? YouTubeViewersDetailsViewModel { get; }
        public ICommand? AddYouTubeViewersCommand { get; }

        public YouTubeViewerViewModel(SelectedYouTubeViewerStore _selectedYouTubeViewerStore)
        {
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selectedYouTubeViewerStore);
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel(_selectedYouTubeViewerStore);
        }

    }
}
