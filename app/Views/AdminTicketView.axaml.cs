using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace app.Views
{
    public partial class AdminTicketView : UserControl
    {
        public AdminTicketView ()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CreateTicket_Click(object sender, RoutedEventArgs e){
                Window CreateTicket = new CreateTicketView();
                CreateTicket.Show();
        }

        private void TicketInfo_Click(object sender, RoutedEventArgs e){
                Window TicketInfo = new AdminTicketInfoView();
                TicketInfo.Show();
        }
    }
}