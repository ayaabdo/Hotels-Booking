using Hotel_Booking.Core.IRepositories.Base;
using Hotel_Booking.Entities.Entities;

namespace Hotel_Booking.Framwork.Core.IRepositories
{
    public interface IRoomRepository : IRepository<Room, long>
    {
    }
}