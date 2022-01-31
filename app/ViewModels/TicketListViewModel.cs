using System.Collections.Generic;
using System.Collections.ObjectModel;
using app.Models;

namespace app.ViewModels
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
