namespace Hotel_Booking.Core.Core.Entities
{
    public interface IEntityIdentity<TEntityIdentity>
    {
        TEntityIdentity Id { get; set; }
    }
}