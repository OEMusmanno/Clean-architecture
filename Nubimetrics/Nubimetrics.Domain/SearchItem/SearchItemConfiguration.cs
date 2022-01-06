using AutoMapper;
using Nubimetrics.DalContracts.Meli;
using Nubimetrics.DalEntities.SearchItem;
using Nubimetrics.DomainContracts.SearchItem;
using System.Threading.Tasks;

namespace Nubimetrics.Domain.SearchItem
{
    public class SearchItemConfiguration : ISearchItemConfiguration
    {

        private readonly IMeliWebRepository _meliWebRepository;
        private readonly IMapper _mapper;

        public SearchItemConfiguration(IMeliWebRepository meliWebRepository, IMapper mapper)
        {
            _meliWebRepository = meliWebRepository;
            _mapper = mapper;
        }
        public async Task<Item> GetItemAsync(string item)
        {
            var result = await _meliWebRepository.GetItemAsync(item);
            return _mapper.Map<Item>(result);
        }
    }
}
