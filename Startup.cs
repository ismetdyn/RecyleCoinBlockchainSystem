using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Coravel;
using RecycleCoinServer.Grpc;

namespace RecycleCoinServer
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders(
                    "Grpc-Status",
                    "Grpc-Message",
                    "Grpc-Encoding",
                    "Grpc-Accept-Encoding");
            }));   
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // web uygulamasından destek grpc çağrısı ekle,
            // UseRouting ve UseEndpoints arasına eklenmelidir
            app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<HesapGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGrpcService<BlokGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGrpcService<EsGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGrpcService<HisseGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGrpcService<IslemGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGrpcService<GenelBilgiGrpcServis>().RequireCors("AllowAll");
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(
                        "Communication with gRPC endpoints" +
                        " must be made through a gRPC client.");
                });
            });
        }
    }
}
