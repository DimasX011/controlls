using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.NetworkReposity
{
    public class AllNetworkMetrics
    {
        public List<NetworkMetricDto> networkMetricDtos { get; set; }
    }
    public class NetworkMetricDto
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}
