using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.NetworkReposity
{

    public interface INetworkMetrics : INetworkReposity<NetworkData>
    {

    }

    public class NetworkReposityMethods : INetworkMetrics
    {

        private const string ConnectionString = "Data Source=metrics.db;Version=3;Pooling=true;Max Pool Size=100;";

        public IList<NetworkData> GetByTimePeriod()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            using var cmd = new SQLiteCommand(connection);

            
            cmd.CommandText = "SELECT * FROM cpumetrics";

            var returnList = new List<NetworkData>();

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    
                    returnList.Add(new NetworkData
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
