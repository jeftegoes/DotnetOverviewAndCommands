namespace ProjectMonitorSitesWorkerService.Core.Models
{
    public class ResultMonitor
    {
        public string Time { get; set; }
        public string Host { get; set; }
        public string Status { get; set; }
        public object Exception { get; set; }
    }
}