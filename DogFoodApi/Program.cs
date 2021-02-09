using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Sentry.AspNetCore;
using System;

namespace DogFoodApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                webBuilder.UseStartup<Startup>();
                Action<SentryAspNetCoreOptions> test = (test2) => 
                {
                    test2.Debug = true;
                    test2.Dsn = "https://80aed643f81249d4bed3e30687b310ab@o447951.ingest.sentry.io/5428537";
                    test2.ReportAssemblies = false;
                    test2.TracesSampleRate = 0.0001f;
                };
                webBuilder.UseSentry(test);
    });           
}
}
