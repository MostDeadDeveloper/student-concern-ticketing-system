using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using Avalonia.Interactivity;
using ReactiveUI;
using app.Models;
using app.Services;

namespace app.ViewModels
{
    class CreateTicketViewModel : ViewModelBase
    {
        public string Description;

        public CreateTicketViewModel () {
            command = ReactiveCommand.Create(SaveChanges);
        }

        public ReactiveCommand<Unit, Unit> command { get; }

        public void SaveChanges () {
            //
        }
        private void OnButtonClick(object sender, RoutedEventArgs e) {}

    }
}
