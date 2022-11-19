using Microsoft.Extensions.DependencyInjection;
using Production.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.DependencyInjection
{
    public class DIContainer : IDIContainer
    {
        private readonly IServiceProvider _serviceProvider;

        public DIContainer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public T Resolve<T>()
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
