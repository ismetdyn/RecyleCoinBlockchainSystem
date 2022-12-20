using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();

            ServisHavuzu.Ekle(
                new CuzdanServisi(),
                new VaritabaniServisi(),
                new ArayuzServisi(),
                new BlokBasimServisi(),
                new EstenEseServis());
            ServisHavuzu.Baslat();

            // grpc
            IHost host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSystemd()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options =>
                    {
                        var GRPC_WEB_PORT = DotNetEnv.Env.GetInt("GRPC_WEB_PORT");
                        var GRPC_PORT = DotNetEnv.Env.GetInt("GRPC_PORT");

                        options.ListenAnyIP(GRPC_WEB_PORT, listenOptions => listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3); //webapi
                        options.ListenAnyIP(GRPC_PORT, listenOptions => listenOptions.Protocols = HttpProtocols.Http2); //grpc
                    });

                    // start
                    webBuilder.UseStartup<Startup>()
                        //   .ConfigureLogging(loggingBuilder => loggingBuilder.ClearProviders());
                        .ConfigureLogging((Action<WebHostBuilderContext, ILoggingBuilder>)((hostingContext, logging) =>
                        {
                            // logging.AddConfiguration((IConfiguration)hostingContext.Configuration.GetSection("Logging"));
                            // logging.AddConsole();
                            // logging.AddDebug();
                            // logging.AddEventSourceLogger();
                            logging.ClearProviders();
                        }));
                    //===
                });
    }
}
