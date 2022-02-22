using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
namespace app.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        // public string? RedRect { get; set; }
        // public string? BlueRect { get; set; }
        private string? Text; 
        public string Home {
            set {Text="This is Home View";} 
        } 
    }
}

