using Microsoft.AspNetCore.Mvc;
using Nubimetrics.DomainContracts.Currency;
using System.Threading.Tasks;

namespace Nubimetrics.Api.Controllers.Currency
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyConfiguration _currencyConfiguration;

        public CurrencyController(ICurrencyConfiguration currencyConfiguration)
        {
            _currencyConfiguration = currencyConfiguration;
        }

        /// <summary>
        /// Realiza la conversion de monedas
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{path}/{fileName}/{extension}")]
        public async Task<IActionResult> Get(string path, string fileName, string extension)
        {
            var _currency = await _currencyConfiguration.GetCurrencyAsync(path, fileName, extension);
            return Ok(_currency);
        }

    }
}
