using System.IO;
using Fibonacci;
using Fibonacci.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddEnvironmentVariables()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var services = new ServiceCollection()
    .AddDbContext<FibonacciDataContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .AddTransient<Compute>()
    .AddLogging();

using var serviceProvider = services.BuildServiceProvider();

var compute = serviceProvider.GetService<Compute>();

app.MapGet("/Fibonacci", async () => compute.ExecuteAsync(new[] {"42", "42", "42"}));
app.Run();