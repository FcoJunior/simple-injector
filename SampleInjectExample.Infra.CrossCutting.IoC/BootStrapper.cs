using SampleInjectExample.Infra.Data.Interfaces;
using SampleInjectExample.Infra.Data.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInjectExample.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
        }
    }
}
