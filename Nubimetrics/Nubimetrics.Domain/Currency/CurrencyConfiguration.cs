using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.Currency;
using Nubimetrics.DomainContracts.Currency;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.Domain.Currency
{
    public class CurrencyConfiguration : ICurrencyConfiguration
    {
        private readonly IMeliWebRepository _meliWebRepository;
        private readonly IMeliFileStreamRepository _meliFileStreamRepository;

        public CurrencyConfiguration(IMeliWebRepository meliWebRepository, IMeliFileStreamRepository meliFileStreamRepository)
        {
            _meliWebRepository = meliWebRepository;
            _meliFileStreamRepository = meliFileStreamRepository;
        }

        public async Task<List<CurrencyDto>> GetCurrencyAsync(string path, string fileName, string extension)
        {
            var currencies = await _meliWebRepository.GetCurrencyAsync();
            var ratios = new List<string>();
            foreach (var item in currencies)
            {
                //Da como resultado un 403 y no realiza la conversion
                if (item.id != "VEF" && item.id != "VES")
                {
                    item.ToDolar = await _meliWebRepository.GetCurrencyConvertionAsync(item.id);
                    ratios.Add(item.ToDolar.ratio.ToString());
                }              
            }
            _meliFileStreamRepository.SaveFileCsv(path, fileName, extension, ratios);
            return currencies;
        }
    }
}
