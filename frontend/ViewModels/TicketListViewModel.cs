using System.Collections.Generic;
using System.Collections.ObjectModel;
using student_concern_ticketing_system.frontend.Models;

namespace student_concern_ticketing_system.frontend.ViewModels
{
    public class TicketListViewModel : ViewModelBase
    {
        public TicketListViewModel(IEnumerable<Ticket> items)
        {
            Items = new ObservableCollection<Ticket>(items);
        }

        public ObservableCollection<Ticket> Items { get; }
    }
}
