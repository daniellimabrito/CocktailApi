using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CocktailApi.Data;
using CocktailApi.Context;

namespace CocktailApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            /*
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<CocktailContext>();  
                context.Database.Migrate();
                Seed.SeedUsers(context);
            }
            catch (Exception ex) 
            {                
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, ex.Message);
            }
            host.Run();

            */

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //.UseUrls("https://localhost:5001");
                });
    }
}
