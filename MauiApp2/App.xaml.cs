using FreshMvvm.Maui;
using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var page = FreshPageModelResolver.ResolvePageModel<TestLandingViewModel>();
		var builderContainer = new FreshNavigationContainer(page);
		MainPage = builderContainer;
	}
}
