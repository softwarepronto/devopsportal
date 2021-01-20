using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DevOpsPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceStats.Init();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
