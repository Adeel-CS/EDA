using mvvm.Models;
using mvvm.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    internal class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYouTubeViewer;

        public bool HasSelectedYouTubeViewer => SelectedYouTubeViewer != null;
        public string Username => SelectedYouTubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string IsMember => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {

            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged;

        }

        private void SelectedYouTubeViewerStore_SelectedYouTubeViewerChanged()
        {
            //OnPropertyChanged(nameof(SelectedYouTubeViewer));
            OnPropertyChanged(nameof(HasSelectedYouTubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsMemberDisplay));
            OnPropertyChanged(nameof(IsSubscribedDisplay));

        }
    }
}
