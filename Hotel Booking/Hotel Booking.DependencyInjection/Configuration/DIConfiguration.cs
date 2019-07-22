using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Hotel_Booking.DependencyInjection.Configuration
{
    public static class DIConfiguration
    {
        public static void Configure(IConfiguration configuration, IServiceCollection services)
        {
            Console.WriteLine("Configure");
        }
    }
}