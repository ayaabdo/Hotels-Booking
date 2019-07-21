using System.Collections.Generic;
using Hotel_Booking.Core.Models.ViewModel.Base;

namespace Hotel_Booking.Core.Models.ViewModel
{
    public interface IViewModelCollection<TViewModel> where TViewModel : IViewModel
    {
        IList<TViewModel> Collection { get; set; }
        long TotalCount { get; set; }
        int? PageIndex { get; set; }
        int? PageSize { get; set; }
    }
}