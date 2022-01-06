using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.Country;
using Nubimetrics.DalEntities.Currency;
using Nubimetrics.DalEntities.SearchItem;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nubimetrics.Dal.Repositories.Meli
{
    public class MeliWebRepository : BaseWEBAPIRepository, IMeliWebRepository
    {     
        public async Task<CountryDto> GetCountryAsync(string country)
        {
           return await GetDataAsync<CountryDto>(string.Format(ApiResource.MeliCountries, country), HttpMethod.Get);        
        }
        public async Task<ItemDto> GetItemAsync(string item)
        {
            return await GetDataAsync<ItemDto>(string.Format(ApiResource.MeliItem, item), HttpMethod.Get);            
        }
        public async Task<List<CurrencyDto>> GetCurrencyAsync()
        {
            return await GetDataAsync<List<CurrencyDto>>(string.Format(ApiResource.MeliCurrency), HttpMethod.Get);
        }
        public async Task<CurrencyConvertionDto> GetCurrencyConvertionAsync(string currency)
        {
            return await GetDataAsync<CurrencyConvertionDto>(string.Format(ApiResource.MeliCurrencyToDolar, currency), HttpMethod.Get);
        }
    }
}
