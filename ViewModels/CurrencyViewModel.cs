using CurrencyMaui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.ViewModels;

public class CurrencyViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private CurrencyWithValueModel _currency;
    private List<CurrencyWithValueModel> _otherCurrencyList;

    public CurrencyWithValueModel Currency
    {
        get { return _currency; }
        set { _currency = value; }
    }

    public decimal Value
    {
        get { return _currency.Value; }
        set { _currency.Value = value; OnPropertyChanged(); OnPropertyChanged("OtherCurrencyList"); }
    }

    public List<CurrencyWithValueModel> OtherCurrencyList
    {
        get { return _otherCurrencyList; }
        set { _otherCurrencyList = value; }
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
