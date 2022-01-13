using System;
using System.Collections.Generic;
using System.Text;
using student_concern_ticketing_system.frontend.Services;

namespace student_concern_ticketing_system.frontend.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TicketListViewModel(db.GetItems());
        }

        public TicketListViewModel List { get; }
    }
}
