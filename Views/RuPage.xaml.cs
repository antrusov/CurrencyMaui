using CurrencyMaui.Models;

namespace CurrencyMaui.Views;

public partial class RuPage : ContentPage
{
	public RuPage(CurrencyCalculatorModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}