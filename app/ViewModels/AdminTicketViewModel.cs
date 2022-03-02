namespace app.ViewModels
{
    class AdminTicketViewModel : ViewModelBase
    {
        private string? Text;
        public string? Ticket {
            set {Text="This is Ticket View";}
        }
    }
}