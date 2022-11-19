using Microsoft.Extensions.DependencyInjection;
using Production.Framework.Core.Assemblyhelper;

namespace Production.Framework.Core.DependencyInjection
{
    public interface IRegistrar
    {
        void Register(IServiceCollection serviceCollection, IAssemblyDiscovery assemblyDiscovery);
    }
}
