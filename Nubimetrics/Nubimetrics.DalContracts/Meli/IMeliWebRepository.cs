using Nubimetrics.DalEntities.Country;
using Nubimetrics.DalEntities.Currency;
using Nubimetrics.DalEntities.SearchItem;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nubimetrics.DalContracts.Meli
{
    public interface IMeliWebRepository
    {
        Task<CountryDto> GetCountryAsync(string country);
        Task<ItemDto> GetItemAsync(string item);
        Task<List<CurrencyDto>> GetCurrencyAsync();
        Task<CurrencyConvertionDto> GetCurrencyConvertionAsync(string currency);

    }
}
