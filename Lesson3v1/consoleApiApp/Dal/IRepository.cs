using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.Dal
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll(SQLiteConnection connection, List<CpuMetric> returnList);

        T GetById(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);
    }

}
