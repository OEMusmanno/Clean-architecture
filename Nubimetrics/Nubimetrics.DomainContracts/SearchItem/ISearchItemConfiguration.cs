using Nubimetrics.DalEntities.SearchItem;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nubimetrics.DomainContracts.SearchItem
{
    public interface ISearchItemConfiguration
    {
        Task<ItemDto> GetItemAsync(string Item);
    }
}
