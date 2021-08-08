using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.NetworkReposity
{
    public interface INetworkReposity<T> where T: class
    {
        IList<T> GetByTimePeriod();
    }
}
