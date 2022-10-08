using CurrencyMaui.Interfaces;
using CurrencyMaui.Services;
using CurrencyMaui.ViewModels;
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

		builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<AppShellViewModel>();

        builder.Services.AddSingleton<CurrencyCalculatorModel>();
        builder.Services.AddSingleton<SettingsPage>();
        builder.Services.AddSingleton<ICurrencyService, CurrencyLocalDbService>();

        return builder.Build();
	}
}
