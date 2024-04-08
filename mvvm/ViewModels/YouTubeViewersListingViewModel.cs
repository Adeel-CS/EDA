﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    internal class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel>? _youTubeViewersListingItemViewModels;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;

        public YouTubeViewersListingViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Jhon"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Ricky"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Alan"));
        }

    }
}