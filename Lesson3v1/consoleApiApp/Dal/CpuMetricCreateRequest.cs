using System;

namespace consoleApiApp.Controllers
{
    public class CpuMetricCreateRequest
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }

}