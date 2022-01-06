using Autofac;
using Nubimetrics.Domain.Country;
using Nubimetrics.Domain.Currency;
using Nubimetrics.Domain.SearchItem;
using Nubimetrics.DomainContracts.Country;
using Nubimetrics.DomainContracts.Currency;
using Nubimetrics.DomainContracts.SearchItem;

namespace Nubimetrics.Composition
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryConfiguration>().As<ICountryConfiguration>();
            builder.RegisterType<SearchItemConfiguration>().As<ISearchItemConfiguration>();
            builder.RegisterType<CurrencyConfiguration>().As<ICurrencyConfiguration>();
        }
    }
}
