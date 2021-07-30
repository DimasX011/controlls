using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.HddReposity
{
    public class AllHddMetrics
    {
        public List<HddMetricDto> hddMetricDtos { get; set; }
    }

    public class HddMetricDto
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}
