using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.Core.ApplicationService
{
    public abstract class Command
    {
        protected Command()
        {
            ExecuteDateTime = DateTime.Now;

        }
        public DateTime ExecuteDateTime { get;}
    }
}
