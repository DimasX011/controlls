using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.AgentReposity
{
    public interface IAgentReposity<T> where T : class
    {
        IList<T> GetByTimePeriod();
    }
}
