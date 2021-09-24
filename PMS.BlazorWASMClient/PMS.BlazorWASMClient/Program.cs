using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PMS.APIFramework.Services;
using PMS.APIFramework.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BlazorWASMClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration.GetValue<string>("APIBaseURL"))
            });

            builder.Services.AddOptions();
            builder.Services.AddScoped<IApiTestService, ApiTestService>();

            await builder.Build().RunAsync();
        }
    }
}
