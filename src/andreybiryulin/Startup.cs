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
                .AddXmlDataContractSerializerFormatters()
                .Services
            .AddScoped<RoutingInfo>()
            .AddSingleton<DI_A>()
            .AddSingleton<DI_B>()
            .AddSingleton<DI_C>()
            .AddSingleton<DI_D>()
            .AddInstance(DIModelFactory.Instance)
            .AddSingleton<DIModelCtor>();

        public void Configure(IApplicationBuilder app) => app
            .UseIISPlatformHandler()
            .UseStaticFiles()
            .UseDeveloperExceptionPage()
            .UseMvc(routes => routes
                .MapRoute(
                    "area",
                    "{area:exists}/{controller=Home}/{action=Index}")
                .MapRoute(
                    "actions",
                    "{controller=Home}/{action=Index}/{id?}")
                .MapRoute(
                    "404 Page Not Found",
                    "{*url}",
                    new { controller = "Home", action = "Error" })
            );

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
