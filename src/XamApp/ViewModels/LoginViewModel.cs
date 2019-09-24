using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Bit.ViewModel;
using WithLottie.Resources;

namespace WithLottie.ViewModels
{
    public class LoginViewModel : BitViewModelBase
    {
        public bool ShowLoading { get; set; } = false;
        public string ShowAnimation { get; set; } = "Show Animation!";
        public BitDelegateCommand ClickCommand { get; set; }

        public bool VisibleAnimation { get; set; }
        public LoginViewModel()
        {
            ClickCommand = new BitDelegateCommand(GoToLoading);
        }

        private async Task GoToLoading()
        {
            ShowLoading = !ShowLoading;
            ShowAnimation = ShowLoading ? "Stop It!" : "Show Animation!";
        }

    }
}
