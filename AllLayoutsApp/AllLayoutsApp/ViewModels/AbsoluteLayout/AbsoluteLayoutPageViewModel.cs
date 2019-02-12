using System;
using Prism.Commands;
using Prism.Navigation;

namespace AllLayoutsApp.ViewModels.AbsoluteLayout
{
    public class AbsoluteLayoutPageViewModel: ViewModelBase
    {
        public DelegateCommand GoNextCommand { get; set; }
        public AbsoluteLayoutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Absolute Layout";
            GoNextCommand = new DelegateCommand(GoToNextPage);
        }

        private async void GoToNextPage()
        {
            await NavigationService.NavigateAsync("ComplexAbsoluteLayoutPage");
        }
    }
}
