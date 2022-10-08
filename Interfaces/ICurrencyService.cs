using CurrencyMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.Interfaces;

public interface ICurrencyService
{
    public List<CurrencyModel> GetAll();
    public int Create(CurrencyModel model);
    public CurrencyModel Read(int id);
    public void Update(CurrencyModel model);
    public void Delete(int id);
}
