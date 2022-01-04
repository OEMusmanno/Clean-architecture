using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nubimetrics.Composition
{
    public class CompositionRoot
    {
        public static void Build(ContainerBuilder container)
        {
            container.RegisterModule<DomainModule>();
            container.RegisterModule<DataAccessModule>();
        }
    }
}
