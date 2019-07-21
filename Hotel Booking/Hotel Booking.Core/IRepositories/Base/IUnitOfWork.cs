namespace Hotel_Booking.Core.IRepositories.Base
{
    public interface IUnitOfWork
    {
        void Complete();
    }
}