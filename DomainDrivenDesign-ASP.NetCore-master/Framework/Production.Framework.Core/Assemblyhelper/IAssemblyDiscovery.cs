using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.Core.Assemblyhelper
{
    public interface IAssemblyDiscovery
    {
        IEnumerable<T> DiscoverInstances<T>(string searchNameSpace);
        IEnumerable<Type> DiscoverTypes<TInterface>(string searchNameSpace);

    }
}
