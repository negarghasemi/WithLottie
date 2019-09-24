using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Bit.ViewModel;
using Prism.Navigation;
using WithLottie.Resources;

namespace WithLottie.ViewModels
{
    public class LoadingViewModel : BitViewModelBase
    {
      
        public bool ShowFlower { get; set; } = false;
        public LoadingViewModel()
        {
            
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
          //  await Task.Delay(TimeSpan.FromSeconds(10));
            //ShowLoading = false;
            //ShowFlower = true;
            await base.OnNavigatedToAsync(parameters);
        }
    }
}
