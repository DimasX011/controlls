using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleApiApp.RamReposity
{
    public class AllRamMetrics
    {
        public List<RamMetricDto> ramMetricDtos { get; set; }
    }

    public class RamMetricDto
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}
