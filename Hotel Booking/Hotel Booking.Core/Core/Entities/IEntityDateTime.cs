using System;

namespace Hotel_Booking.Core.Core.Entities
{
    public interface IEntityDateTime
    {
        #region Properties       

        /// <summary>
        /// Gets or sets entity CreationDate.
        /// </summary>
        DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets entity FirstModificationDate.
        /// </summary>
        DateTime? FirstModificationDate { get; set; }

        /// <summary>
        /// Gets or sets entity LastModificationDate.
        /// </summary>
        DateTime? LastModificationDate { get; set; }

        #endregion
    }
}