using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers.testclass
{
    public class GetMetricsFromAgentData
    {
        public int value { get; }
        public TimeSpan time { get; }
        public TimeSpan span { get; }

        public GetMetricsFromAgentData(int data, TimeSpan spantime, TimeSpan timeSpan)
        {
            value = data;
            time = spantime;
            span = timeSpan;
        }
    }
}
