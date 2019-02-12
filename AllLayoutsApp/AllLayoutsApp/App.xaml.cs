using Prism;
using Prism.Ioc;
using AllLayoutsApp.ViewModels;
using AllLayoutsApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using AllLayoutsApp.Views.StackLayout;
using AllLayoutsApp.Views.AbsoluteLayout;
using AllLayoutsApp.Views.RelativeLayout;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AllLayoutsApp
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/CustomMasterDetailPage/NavigationPage/StackLayoutPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<StackLayoutPage>();
            containerRegistry.RegisterForNavigation<CustomMasterDetailPage>();
            containerRegistry.RegisterForNavigation<ComplexStackLayoutPage>();
            containerRegistry.RegisterForNavigation<AbsoluteLayoutPage>();
            containerRegistry.RegisterForNavigation<ComplexAbsoluteLayoutPage>();
            containerRegistry.RegisterForNavigation<RelativeLayoutPage>();
            containerRegistry.RegisterForNavigation<ComplexRelativeLayoutPage>();

        }
    }
}
