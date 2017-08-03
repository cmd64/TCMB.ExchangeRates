using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMB.ExchangeRates
{
    public class ExchangeRate
    {
        public string CurrencyCode { get; set; }
        public string Currency { get; set; }
        public string Unit { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BanknoteBuying { get; set; }
        public string BanknoteSelling { get; set; }
    }
}
