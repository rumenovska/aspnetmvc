using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using StudentApp.Data;

namespace StudentApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host =
            CreateWebHostBuilder(args).Build();
            using(var scope= host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var contex = services.GetRequiredService<SchoolContex>();
                    DbInitializer.Initialize(contex);
                }
                catch(Exception ex)
                {
                    
                }
            }

            host.Run();


            
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
