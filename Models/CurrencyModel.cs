using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyMaui.Models
{
    public class CurrencyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public char Symbol { get; set; }
        public decimal GoldEquivalent { get; set; }
        public bool Hidden { get; set; }
    }
}
