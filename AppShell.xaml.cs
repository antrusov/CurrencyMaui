using CurrencyMaui.ViewModels;

namespace CurrencyMaui;

public partial class AppShell : Shell
{
	public AppShell(AppShellViewModel model)
	{
		BindingContext = model;
		InitializeComponent();
	}
}
