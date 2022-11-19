using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.Core.Persistence
{
    public interface IDbContext : IDisposable
    {
        void Migrate();
        int SavaChanges();
    }
}
