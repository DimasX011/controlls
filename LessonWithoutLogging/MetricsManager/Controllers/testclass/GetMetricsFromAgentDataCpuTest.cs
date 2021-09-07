using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers.testclass
{
    public class GetMetricsFromAgentDataCpuTest
    {
        public int value { get; }
        public TimeSpan time { get; }
        public TimeSpan span { get; }

        public GetMetricsFromAgentDataCpuTest(int data, TimeSpan spantime, TimeSpan timeSpan)
        {
            value = data;
            time = spantime;
            span = timeSpan;
        }
    }
}
