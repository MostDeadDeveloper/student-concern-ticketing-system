namespace app.ViewModels
{
    class TicketViewModel : ViewModelBase
    {
        private string? Text;
        public string? Ticket {
            set {Text="This is Ticket View";}
        }
    }
}