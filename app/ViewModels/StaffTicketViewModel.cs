using System.Collections.Generic;
using System.Collections.ObjectModel;
using app.Models;

namespace app.ViewModels
{
    class StaffTicketViewModel : ViewModelBase
    {

        public StaffTicketViewModel(IEnumerable<Ticket> items)
        {
            Tickets = new ObservableCollection<Ticket>(items);
        }

        public ObservableCollection<Ticket> Tickets { get; }
    }
}
