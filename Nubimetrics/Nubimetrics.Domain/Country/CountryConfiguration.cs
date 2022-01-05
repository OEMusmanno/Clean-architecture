using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.Country;
using Nubimetrics.DomainContracts.Country;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

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
