using System.Collections.Generic;
using Hotel_Booking.Core.Models.DTO.Base;

namespace Hotel_Booking.Core.Models.DTO
{
    public interface IDTOCollection<TDTO> where TDTO : IDTO
    {
        IList<TDTO> Collection { get; set; }
        long TotalCount { get; set; }
        int? PageIndex { get; set; }
        int? PageSize { get; set; }
    }
}