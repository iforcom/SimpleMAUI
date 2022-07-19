using MauiApp4.ViewModel;

namespace MauiApp4;

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
		//VM
		builder.Services.AddSingleton<MainPageViewModel>();

		//View
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
