using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nubimetrics.DalEntities.SearchItem;
using Nubimetrics.DomainContracts.SearchItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nubimetrics.Api.Controllers.SearchItem
{
    [Route("api/Busqueda/")]
    [ApiController]
    public class SearchItemController : ControllerBase
    {
        private readonly ISearchItemConfiguration _searchItemConfiguration;
        private readonly ILogger<SearchItemController> _logger;

        public SearchItemController(ILogger<SearchItemController> logger, ISearchItemConfiguration searchItemConfiguration)
        {
            _logger = logger;
            _searchItemConfiguration = searchItemConfiguration;
        }

        /// <summary>
        /// Busqueda de un elemento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{item}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string item)
        {
            var items = await _searchItemConfiguration.GetItemAsync(item);
            return Ok(items);
        }
    }
}
