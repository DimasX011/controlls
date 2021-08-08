using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.DotnetReposity
{

    public interface IDotnetReposityInterface<T> where T : class
    {
        IList<T> GetByTimePeriod();
    }
}
