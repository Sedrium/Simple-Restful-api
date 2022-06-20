using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace CompanySpy.Integration.Test.DataHelper
{
    public class ApiWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                   .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.UseStartup<TStartup>();
                   });
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            builder.ConfigureServices(service=> {
            });

            builder.ConfigureAppConfiguration((context, conf) =>
            {
                conf.AddJsonFile(appSettingsPath);
            });
        }
    }
}
