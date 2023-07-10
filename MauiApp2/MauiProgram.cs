using FreshMvvm.Maui.Extensions;
using MauiApp2.View;
using MauiApp2.ViewModel;

namespace MauiApp2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<TestLandingPage>();
		builder.Services.AddTransient<TestLandingViewModel>();	

		MauiApp mauiApp = builder.Build();
		mauiApp.UseFreshMvvm();

		return mauiApp;

		//return builder.Build();
	}
}
