using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ScanStoreService
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            // read database configuration (database provider + database connection) from environment variables            

            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()                
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var host = new WebHostBuilder()
                .UseConfiguration(config)                
                .UseKestrel()
                .UseIISIntegration()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls($"http://+:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
        
        /*
                public static void Main(string[] args)
                {
                    CreateHostBuilder(args).Build().Run();
                }

                public static IHostBuilder CreateHostBuilder(string[] args) =>
                    Host.CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseKestrel();
                            webBuilder.UseUrls($"http://+:5000");
                            webBuilder.UseStartup<Startup>();
                        });
          */
    }


}
