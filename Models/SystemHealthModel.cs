using DevOpsPortal;

namespace DevOpsPortal.Models
{
    public class SystemHealthModel
    {
        public SystemHealthModel()
        {
            Status = ServiceStats.Status;
            Version = ServiceStats.AssemblyVersionText;
            Uptime = $"Up since {ServiceStats.Started.ToString($"yyyy-MM-dd hh:mm:ss")}";
        }

        public string Status { get; set; }

        public string Version { get; set; }

        public string Uptime { get; set; }
    }
}
