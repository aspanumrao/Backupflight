using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Flight.Service.APIGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //*******************Hosting the application*****************************
            IWebHostBuilder builder = new WebHostBuilder(); //Creation of hosting instance
            builder.ConfigureServices(a =>
            {
                a.AddSingleton(builder);
               
            });

            //Hosting server Declation on which server hosting 
            builder.UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<Startup>()
                    .UseUrls("http://localhost:5000");
            //Build and run the host 

            var host = builder.Build();
            host.Run();


            // ***********************end of hosting application ***********************

            //CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
