using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using AndreyBiryulin.ViewModels;

namespace AndreyBiryulin
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => services
            .AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.Formatting = Formatting.Indented)
            .Services
            .AddScoped<RoutingInfo>();

        public void Configure(IApplicationBuilder app) => app
            .UseIISPlatformHandler()
            .UseStaticFiles()
            .UseDeveloperExceptionPage()
            .UseMvc(routes => routes
                .MapRoute(
                    "area",
                    "{area:exists}/{controller}/{action}",
                    new { controller = "Home", action = "Index" })
                .MapRoute(
                    "actions",
                    "{controller}/{action}",
                    new { controller = "Home", action = "Index" })
            );
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
