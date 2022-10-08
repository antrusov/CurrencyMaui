using CurrencyMaui.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.ViewModels
{
    public class AppShellViewModel
    {
        ICurrencyService _currencyService;

        public List<(string,int)> Data
        {
            get
            {
                return _currencyService
                    .GetAll()
                    .Where(e => !e.Hidden)
                    .Select(e => (e.Name, e.Id))
                    .ToList();
            }
        }

        public AppShellViewModel(ICurrencyService currencyService)
        {
            currencyService = _currencyService;
        }
    }
}
