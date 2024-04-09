using mvvm.Models;
using System.Windows.Input;

namespace mvvm.ViewModels
{
    public record YouTubeViewersListingItemViewModel(YouTubeViewer YouTubeViewer, ICommand EditCommand, ICommand DeleteCommand) : ViewModelBase
    {
        public string Username => YouTubeViewer.Username;

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer) : this(youTubeViewer, default, default)
        {

            // Initialize your EditCommand and DeleteCommand here if needed
            // Example:
            // EditCommand = new RelayCommand(ExecuteEditCommand);
            // DeleteCommand = new RelayCommand(ExecuteDeleteCommand);
        }

        // Define your command execution methods here if necessary
        // Example:
        // private void ExecuteEditCommand()
        // {
        //     // Implement edit logic
        // }

        // private void ExecuteDeleteCommand()
        // {
        //     // Implement delete logic
        // }
    }
}













//using mvvm.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace mvvm.ViewModels
//{
//    public class YouTubeViewersListingItemViewModel : ViewModelBase
//    {
//        public YouTubeViewer YouTubeViewer { get; }

//        public string Username => YouTubeViewer.Username;

//        public ICommand EditCommand { get; } 
//        public ICommand DeleteCommand {  get; }


//        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
//        {
//            YouTubeViewer = youTubeViewer;
//        }

//    }
//}
