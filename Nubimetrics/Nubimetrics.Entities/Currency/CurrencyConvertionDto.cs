using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.DalEntities.Currency
{
    public class CurrencyConvertionDto
    {
        public string currency_base { get; set; }
        public string currency_quote { get; set; }
        public double ratio { get; set; }
        public double rate { get; set; }
        public double inv_rate { get; set; }
        public DateTime creation_Date { get; set; }
        public DateTime valid_until { get; set; }
    }
}
