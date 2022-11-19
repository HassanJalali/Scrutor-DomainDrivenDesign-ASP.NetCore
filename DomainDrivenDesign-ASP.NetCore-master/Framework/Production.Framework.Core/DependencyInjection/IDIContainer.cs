using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.Core.DependencyInjection
{
    public interface IDIContainer
    {
        T Resolve<T>();
    }
}
