using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers.testclass
{
    public class GetMetricsFromAllClusterAgentData
    {
        public TimeSpan timeSpan { get; }

        public TimeSpan TimeSpan { get; }

        public GetMetricsFromAllClusterAgentData( TimeSpan time, TimeSpan span)
        {
            timeSpan = time;
            TimeSpan = span;
        }
    }
}
