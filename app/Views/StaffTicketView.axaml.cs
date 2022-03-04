using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using app.ViewModels;

namespace app.Views
{
    public partial class StaffTicketView : UserControl
    {
        public StaffTicketView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CreateTicket_Click(object sender, RoutedEventArgs e){
                ViewModelBase CreateTicket = new CreateTicketViewModel();

        }

        private void TicketInfo_Click(object sender, RoutedEventArgs e){
                Window TicketInfo = new StaffTicketInfoView();
                TicketInfo.Show();
        }
    }
}
