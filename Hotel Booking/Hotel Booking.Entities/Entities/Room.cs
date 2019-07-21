using System;
using Hotel_Booking.Core.Core.Entities;

namespace Hotel_Booking.Entities.Entities
{
    public class Room : IEntityIdentity<long>, IEntityDateTime, IVirtualDelete
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? FirstModificationDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastDeletedDate { get; set; }
        public DateTime? LastRestoredDate { get; set; }
    }
}