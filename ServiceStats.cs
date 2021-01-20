using System;

namespace DevOpsPortal
{
    public static class ServiceStats 
    {
        public static DateTime Started { get; }

        static ServiceStats()
        {
            Started = DateTime.UtcNow;
            AssemblyVersion = typeof(ServiceStats).Assembly.GetName().Version;
            Status = "OK";
        }

        /*
            This causes the static constructor to invoke (invoked once)
        */
        public static void Init()
        {            
        }

        public static string Status { get; }

        public static TimeSpan Uptime => DateTime.UtcNow - Started;

        public static string AssemblyVersionText => 
            $"{AssemblyVersion.Major}.{AssemblyVersion.Minor}.{AssemblyVersion.Revision}";

        public static Version AssemblyVersion { get; }
    }
}