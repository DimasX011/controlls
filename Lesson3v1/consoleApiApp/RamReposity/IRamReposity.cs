using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.RamReposity
{
    public interface IRamReposity<T> where T: class
    {
        IList<T> GetByTimePeriod();

    }
}
