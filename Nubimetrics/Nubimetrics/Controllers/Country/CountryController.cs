using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nubimetrics.DalEntities.Country;
using Nubimetrics.DomainContracts.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nubimetrics.Api.Controllers.Country
{
    [Route("api/Paises")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ILogger<CountryController> _logger;
        private readonly ICountryConfiguration _countryConfiguration;

        public CountryController(ILogger<CountryController> logger, ICountryConfiguration countryConfiguration)
        {
            _logger = logger;
            _countryConfiguration = countryConfiguration;
        }     

        /// <summary>
        /// Obtiene un pais en particular
        /// </summary>
        /// <param name="Country"></param>
        /// <returns></returns>
        /// <response code ="401"> Se debe a que es Colombia o Brasil</response>
        //[HttpGet("{country}")]
        ////[ProducesResponseType(typeof(string), statusCode:401)]
        //public async Task<CountryDto> Get(string country)
        //{
        //    return await _countryConfiguration.GetCountryAsync(country);
        //}

        [HttpGet]
        public string status() {
            return "ok";
        }
       
    }
}
