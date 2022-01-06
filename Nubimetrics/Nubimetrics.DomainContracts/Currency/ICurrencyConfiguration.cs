using Nubimetrics.DalEntities.Currency;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nubimetrics.DomainContracts.Currency
{
    public interface ICurrencyConfiguration
    {
        Task<List<CurrencyDto>> GetCurrencyAsync(string path, string fileName, string extension);
    }
}
