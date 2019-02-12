using System;
using Prism.Commands;
using Prism.Navigation;

namespace AllLayoutsApp.ViewModels.RelativeLayout
{
    public class RelativeLayoutPageViewModel : ViewModelBase
    {
        public DelegateCommand GoNextCommand { get; set; }
        public RelativeLayoutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Relative Layout";
            GoNextCommand = new DelegateCommand(GoToNextPage);
        }

        private async void GoToNextPage()
        {
            await NavigationService.NavigateAsync("ComplexRelativeLayoutPage");
        }
    }
}
