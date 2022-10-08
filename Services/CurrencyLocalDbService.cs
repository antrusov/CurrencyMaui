using CurrencyMaui.Interfaces;
using CurrencyMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.Services;

public class CurrencyLocalDbService: ICurrencyService
{
    public List<CurrencyModel> GetAll() { return null; } //todo
    public int Create(CurrencyModel model) { return 0; } //todo
    public CurrencyModel Read(int id) { return null; } //todo
    public void Update(CurrencyModel model) { } //todo
    public void Delete(int id) { } //todo
}
