using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.Models;

public class CurrencyCalculatorModel: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private int _ru2gold = 10;
    private int _usd2gold = 20;
    private int _eur2gold = 30;

    public int Ru2Gold
    {
        get { return _ru2gold; }
        set { _ru2gold = value; OnPropertyChanged(); }
    }
    public int Usd2Gold
    {
        get { return _usd2gold; }
        set { _usd2gold = value; OnPropertyChanged(); }
    }
    public int Eur2Gold
    {
        get { return _eur2gold; }
        set { _eur2gold = value; OnPropertyChanged(); }
    }

    //ru
    private double _ru = 0;
    public double Ru
    {
        get { return _ru; }
        set { if (_ru != value) { _ru = value; OnPropertyChanged(); OnPropertyChanged("Ru2Usd"); OnPropertyChanged("Ru2Eur"); } }
    }
    public double Ru2Usd
    {
        get => Convert(Ru, Ru2Gold, Usd2Gold);
    }
    public double Ru2Eur
    {
        get => Convert(Ru, Ru2Gold, Eur2Gold);
    }

    private double Convert(double from, double fromCost, double toCost) =>
        from * fromCost / (toCost == 0 ? 1 : toCost);

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
