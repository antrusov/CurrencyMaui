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
        set { _ru2gold = value; OnPropertyChanged(); OnNeedRecalcAll(); }
    }
    public int Usd2Gold
    {
        get { return _usd2gold; }
        set { _usd2gold = value; OnPropertyChanged(); OnNeedRecalcAll(); }
    }
    public int Eur2Gold
    {
        get { return _eur2gold; }
        set { _eur2gold = value; OnPropertyChanged(); OnNeedRecalcAll(); }
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

    //usd
    private double _usd = 0;
    public double Usd
    {
        get { return _usd; }
        set { if (_usd != value) { _usd = value; OnPropertyChanged(); OnPropertyChanged("Usd2Ru"); OnPropertyChanged("Usd2Eur"); } }
    }
    public double Usd2Ru
    {
        get => Convert(Usd, Usd2Gold, Ru2Gold);
    }
    public double Usd2Eur
    {
        get => Convert(Usd, Usd2Gold, Eur2Gold);
    }

    //eur
    private double _eur = 0;
    public double Eur
    {
        get { return _eur; }
        set { if (_eur != value) { _eur = value; OnPropertyChanged(); OnPropertyChanged("Eur2Usd"); OnPropertyChanged("Eur2Ru"); } }
    }
    public double Eur2Usd
    {
        get => Convert(Eur, Eur2Gold, Usd2Gold);
    }
    public double Eur2Ru
    {
        get => Convert(Eur, Eur2Gold, Ru2Gold);
    }

    private void OnNeedRecalcAll()
    {
        OnPropertyChanged("Ru2Usd");
        OnPropertyChanged("Ru2Eur");
        OnPropertyChanged("Usd2Ru");
        OnPropertyChanged("Usd2Eur");
        OnPropertyChanged("Eur2Usd");
        OnPropertyChanged("Eur2Ru");
    }

    private double Convert(double from, double fromCost, double toCost) =>
        from * fromCost / (toCost == 0 ? 1 : toCost);

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
