using AutoMapper;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.Country;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.Dal.Repositories.Meli
{
    public class MeliWebRepository : BaseWEBAPIRepository, IMeliWebRepository
    {     
        public async Task<CountryDto> GetCountryAsync(string country)
        {
           return await GetDataAsync<CountryDto>(string.Format(ApiResource.MeliCountries, country), HttpMethod.Get);        
        }
    }
}
