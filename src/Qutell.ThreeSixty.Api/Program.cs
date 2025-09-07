using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Qutell.ThreeSixty.Application.Interfaces;
using Qutell.ThreeSixty.Application.Services;
using Qutell.ThreeSixty.Infrastructure.Data;
using Qutell.ThreeSixty.Infrastructure.UnitofWork;
using Serilog;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSingleton<IInterceptor, SoftDeleteInterceptor>();
        builder.Services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            var interceptor = sp.GetServices<IInterceptor>().ToArray(); ;

            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection"))
                .AddInterceptors(interceptor);
        });
        builder.Host.UseSerilog((context, services, configuration) =>
           configuration.ReadFrom.Configuration(context.Configuration));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddMemoryCache();
        builder.Services.AddScoped(typeof(ILookupCacheService<,>), typeof(LookupCacheService<,>));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHealthChecks();
        builder.Services.AddControllers();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();
        app.MapHealthChecks("/health");

        await app.RunAsync().ConfigureAwait(false);
    }
}