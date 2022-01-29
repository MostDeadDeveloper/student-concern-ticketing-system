using System;
using System.Collections.Generic;
using System.Text;
using app.Services;

namespace app.ViewModels
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
