using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateWebHostBuilder(
                args.Where(arg => arg != "--console").ToArray());

            var host = builder.Build();

            
            host.Run();
             
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                // Configure the app here.
            })
                .UseUrls("http://*:5050")
                .UseStartup<Startup>();
    }
}
