using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    internal class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }
        public string IsSubscribedDisplay { get; }
        public string IsMemberDisplay { get; }

        public YouTubeViewersDetailsViewModel()
        {
            Username = "RandomNigga";
            IsSubscribedDisplay = "Yes";
            IsMemberDisplay = "No";
        }

    }
}
