using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers.testclass
{
    public class GetMetricsFromAllClusterAgentDataCpuTest
    {
        public TimeSpan timeSpan { get; }

        public TimeSpan TimeSpan { get; }

        public GetMetricsFromAllClusterAgentDataCpuTest( TimeSpan time, TimeSpan span)
        {
            timeSpan = time;
            TimeSpan = span;
        }
    }
}
