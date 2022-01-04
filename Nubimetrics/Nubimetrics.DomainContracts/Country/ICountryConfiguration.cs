using Nubimetrics.DalEntities.Country;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.DomainContracts.Country
{
    public interface ICountryConfiguration
    {
        Task<CountryDto> GetCountryAsync(string country);

    }
}
