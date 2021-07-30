using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace consoleApiApp.DotnetReposity
{
    public interface IDotnetMetricsRepository : IDotnetReposityInterface<DotnetData>
    {

    }

    public interface DotnetReposityInterfaceMethods : IDotnetMetricsRepository
    {
        private const string ConnectionString = "Data Source=metrics.db;Version=3;Pooling=true;Max Pool Size=100;";

        public IList<DotnetData> GetByTimePeriod()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            using var cmd = new SQLiteCommand(connection);

            cmd.CommandText = "SELECT * FROM cpumetrics";

            var returnList = new List<DotnetData>();

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
              
                while (reader.Read())
                {
                 
                    returnList.Add(new DotnetData
                    {
                        Id = reader.GetInt32(0),
                        Value = reader.GetInt32(1),
                        
                        Time = TimeSpan.FromSeconds(reader.GetInt32(2))
                    });
                }
            }

            return returnList;
        }
    }
}