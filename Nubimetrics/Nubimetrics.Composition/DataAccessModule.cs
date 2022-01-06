using Autofac;
using Nubimetrics.Dal.Repositories;
using Nubimetrics.Dal.Repositories.Meli;
using Nubimetrics.DalContracts.Meli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Composition
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MeliWebRepository>().As<IMeliWebRepository>();
            builder.RegisterType<MeliFileStreamRepository>().As<IMeliFileStreamRepository>();
        }
    }
}
