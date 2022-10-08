using CurrencyMaui.ViewModels;

namespace CurrencyMaui.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(CurrencyCalculatorModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}