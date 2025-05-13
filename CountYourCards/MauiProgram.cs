using CountYourCards.ViewModels;
using CountYourCards.Views;
using CountYourCards.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace CountYourCards;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddTransient<Formular>();
        builder.Services.AddTransient<FormularViewModel>();
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<Watten>();
		builder.Services.AddTransient<WattenViewModel>();

        builder.Services.AddDbContext<DbManagerSQLite>();

        return builder.Build();
	}
}
