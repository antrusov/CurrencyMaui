using CurrencyMaui.Models;

namespace CurrencyMaui.Views;

public partial class UsdPage : ContentPage
{
	public UsdPage(CurrencyCalculatorModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}