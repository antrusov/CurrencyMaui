using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.Models
{
    public class CurrencyWithValueModel: CurrencyModel
    {
        public decimal Value { get; set; }
    }
}
