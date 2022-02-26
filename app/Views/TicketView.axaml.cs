using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace app.Views
{
    public partial class TicketView : UserControl
    {
        public TicketView()
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
    }
}