using CurrencyMaui.Models;
using CurrencyMaui.Views;

namespace CurrencyMaui;

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

		builder.Services.AddSingleton<CurrencyCalculatorModel>();
        builder.Services.AddSingleton<RuPage>();
        builder.Services.AddSingleton<UsdPage>();
        builder.Services.AddSingleton<EurPage>();
        builder.Services.AddSingleton<SettingsPage>();

        return builder.Build();
	}
}
