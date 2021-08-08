using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.AgentReposity
{
    public class AllAgentMetricsResponse
    {
        public List<AgentMetricsDto> agentMetrics { get; set; }
 
    }

    public class AgentMetricsDto
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }

}
