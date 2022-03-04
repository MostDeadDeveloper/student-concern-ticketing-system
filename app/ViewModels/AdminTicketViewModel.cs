using System.Collections.Generic;
using System.Collections.ObjectModel;
using app.Models;

namespace app.ViewModels
{
    class AdminTicketViewModel : ViewModelBase
    {
        private string? Text;
        public string? Ticket {
            set {Text="This is Ticket View";}
       }
        public AdminTicketViewModel(IEnumerable <Ticket> items)
        {
            Tickets = new ObservableCollection<Ticket>(items);
        }
        public ObservableCollection<Ticket> Tickets { get; }

    }
}
