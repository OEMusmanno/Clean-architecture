using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.Country;
using Nubimetrics.DomainContracts.Country;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.Domain.Country
{
    public class CountryConfiguration : ICountryConfiguration
    {
        private readonly IMeliWebRepository _meliWebRepository;

        public CountryConfiguration(IMeliWebRepository meliWebRepository)
        {
            _meliWebRepository = meliWebRepository;
        }
        public Task<CountryDto> GetCountryAsync(string country)
        {
            return _meliWebRepository.GetCountryAsync(country);
        }
    }
}
