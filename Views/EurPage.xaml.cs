using CurrencyMaui.Models;

namespace CurrencyMaui.Views;

public partial class EurPage : ContentPage
{
	public EurPage(CurrencyCalculatorModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}