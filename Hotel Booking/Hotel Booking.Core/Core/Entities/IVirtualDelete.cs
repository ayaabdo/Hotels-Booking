using System;

namespace Hotel_Booking.Core.Core.Entities
{
    public interface IVirtualDelete
    {
        #region Properties

        bool IsDeleted { get; set; }
        DateTime? LastDeletedDate { get; set; }
        DateTime? LastRestoredDate { get; set; }

        #endregion
    }
}