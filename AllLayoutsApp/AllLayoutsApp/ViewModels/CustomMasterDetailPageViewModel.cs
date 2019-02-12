using System;
using Prism.Commands;
using Prism.Navigation;

namespace AllLayoutsApp.ViewModels
{
    public class CustomMasterDetailPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> OnNavigateCommand { get; set; }

        public CustomMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnNavigateCommand = new DelegateCommand<string>(NavigateAync);
        }

        private async void NavigateAync(string page)
        {
            await NavigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }
    }
}
