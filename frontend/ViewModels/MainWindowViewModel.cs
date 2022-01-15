﻿using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using student_concern_ticketing_system.frontend.Services;

namespace student_concern_ticketing_system.frontend.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            Content = List = new TicketListViewModel(db.GetItems());
        }

        public TicketListViewModel List { get; }

        public void OnClickCommand()
        {
            // do something
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void HomeView()
        {
            Content = new HomeViewModel();
        }

        public void ReportView()
        {
            Content = new ReportViewModel();
        }
  
    }
}
