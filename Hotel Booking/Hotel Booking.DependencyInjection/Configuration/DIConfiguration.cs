using System;
using Hotel_Booking.Core.IRepositories.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel_Booking.DependencyInjection.Configuration
{
    public static class DIConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            Console.WriteLine("Configure");
        }
    }
}