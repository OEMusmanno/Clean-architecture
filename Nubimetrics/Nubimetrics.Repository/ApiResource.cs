using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Dal
{
    public static class ApiResource
    {
        public const string MeliCountries = "https://api.mercadolibre.com/classified_locations/countries/{0}";
        public const string MeliItem = "https://api.mercadolibre.com/sites/MLA/search?q={0}";
        public const string MeliCurrency = "https://api.mercadolibre.com/currencies/";
        public const string MeliCurrencyToDolar = "https://api.mercadolibre.com/currency_conversions/search?from={0}&to=USD";

    }
}
