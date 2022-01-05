using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nubimetrics.DalEntities.Country;
using Nubimetrics.DomainContracts.Country;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nubimetrics.Api.Controllers.Country
{
    [Microsoft.AspNetCore.Mvc.Route("api/Paises")]
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
        /// Obtiene un informacion de un pais 
        /// </summary>
        /// <param name="Country"></param>
        /// <returns></returns>
        /// <response code ="401"> Se debe a que es Colombia o Brasil</response>
        [HttpGet("{country}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Get(string country)
        {
            switch (country.ToUpper())
            {
                case "BR":
                    return StatusCode(401, "Error 401 - Unauthorized Country");
                case "CO":
                    return StatusCode(401, "Error 401 - Unauthorized Country");
                default:
                    var _country = await _countryConfiguration.GetCountryAsync(country.ToUpper());
                    return Ok(_country);                    
            }
        }
    }
}
