using System;
using Prism.Commands;
using Prism.Navigation;

namespace AllLayoutsApp.ViewModels
{
    public class StackLayoutPageViewModel: ViewModelBase
    {
        public DelegateCommand GoNextCommand { get; set; }
        public StackLayoutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Stack Page";
            GoNextCommand = new DelegateCommand(GoToNextPage);
        }

        private async void GoToNextPage()
        {
            await NavigationService.NavigateAsync("ComplexStackLayoutPage");
        }
    }
}
