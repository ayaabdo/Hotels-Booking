using System;
using Hotel_Booking.DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel_Booking.DataAccess.Configuration
{
    public static class ContextConfiguration
    {
        public static void Configuration(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<HotelsContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("HotelBookingDatabase"),
                    sqlServerOptions => sqlServerOptions.MigrationsAssembly("Hotel Booking.DataAccess")));
        }

        public static void RunMigrations(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<HotelsContext>().Database.Migrate();
                // scope.ServiceProvider.GetRequiredService<PersistedGrantDbContext>().Database.Migrate();
            }
        }

        public static string GetConnectionString()
        {
            // get root path for the project
            string projectPath =
                AppDomain.CurrentDomain.BaseDirectory.Split(new String[] {@"bin"}, StringSplitOptions.None)[0];

            // environment name to get production or development
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // configure the appsittings.json file to get connection string
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath + "..//Hotel Booking/")
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{envName}.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HotelBookingDatabase");
            return connectionString;
        }
    }
}