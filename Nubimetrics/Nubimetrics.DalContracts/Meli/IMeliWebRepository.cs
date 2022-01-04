using Nubimetrics.DalEntities.Country;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.DalContracts.Meli
{
    public interface IMeliWebRepository
    {
        Task<CountryDto> GetCountryAsync(string country);
    }
}
