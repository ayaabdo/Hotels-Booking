using Hotel_Booking.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hotel_Booking.DataAccess.Context
{
    public class HotelsContext : DbContext
    {
        public HotelsContext(DbContextOptions<HotelsContext> options) : base(options)
        {
        }


        #region Database Sets For Hotel Context

        public DbSet<Room> Rooms { get; set; }

        #endregion
    }
}