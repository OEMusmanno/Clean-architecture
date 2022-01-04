using Autofac;
using Nubimetrics.Domain.Country;
using Nubimetrics.DomainContracts.Country;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Composition
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CountryConfiguration>().As<ICountryConfiguration>();
        }
    }
}
