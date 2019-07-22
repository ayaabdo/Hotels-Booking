using System;
using Hotel_Booking.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hotel_Booking.DataAccess.Configuration
{
    public class HotelsContextFactory : IDesignTimeDbContextFactory<HotelsContext>
    {
        public HotelsContext CreateDbContext(string[] args)
        {
            var connectionString = ContextConfiguration.GetConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<HotelsContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new HotelsContext(optionsBuilder.Options);
        }
    }
}